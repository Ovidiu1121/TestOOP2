using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2
{
    public class Linie:IFigura,IComparable<Linie>
    {
        private Punct punct1;
        private Punct punct2;

        public Linie()
        {

        }

        public Linie(Punct punct1,Punct punct2)
        {
            this.punct1 = punct1;
            this.punct2 = punct2;
        }

        public Punct Punct1
        {
            get { return this.punct1; }
            set { this.punct1 = value; }
        }

        public Punct Punct2
        {
            get { return this.punct2; }
            set { this.punct2 = value;}
        }

        public override string ToString()
        {
            string text = "linie=>  ";

            text+=this.punct1+" ";
            text+=this.punct2+" ";

            return text;
        }

        public override bool Equals(object? obj)
        {
            Linie linie = obj as Linie;

            if (linie.Punct1.Equals(this.punct1))
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
            this.punct1.translatare(x, y);
            this.punct2.translatare(x, y);
        }

        public IFigura duplicare()
        {
            return new Linie(this.punct1 , this.punct2);
        }

        public int CompareTo(Linie? other)
        {
            if (this.punct1.X>other.punct1.X)
            {
                return 1;
            }
            else if (this.punct1.X<other.punct1.X)
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
