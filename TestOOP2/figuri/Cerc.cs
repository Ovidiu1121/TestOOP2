using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2.figuri
{
    public class Cerc:IFigura,IComparable<Cerc>
    {
        private Punct punct;
        private Linie linie;

        public Cerc()
        {

        }

        public Cerc(Punct punct,Linie linie)
        {
            this.punct = punct;
            this.linie = linie;
        }

        public Punct Punct
        {
            get { return this.punct; }
            set { this.punct = value; }
        }

        public Linie Linie
        {
            get { return this.linie; }
            set { this.linie = value; }
        }

        public override string ToString()
        {
            string text = "cerc:\n";

            text+=this.punct+" ";
            text+=this.linie+" ";

            return text;
        }

        public override bool Equals(object? obj)
        {
            Cerc cerc = obj as Cerc;

            if (cerc.Punct.Equals(this.punct))
            {
                return true;
            }
            return false;
        }

        public void afisare()
        {
            Console.WriteLine(this);
        }

        public void translatare(int x, int y)
        {
            this.punct.translatare(x, y);
           this.linie.translatare(x,y);
        }

        public IFigura duplicare()
        {
            return new Cerc(this.punct, this.linie);
        }

        public int CompareTo(Cerc? other)
        {
            if (this.punct.X>other.punct.X)
            {
                return 1;
            }
            else if (this.punct.X<other.punct.X)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
