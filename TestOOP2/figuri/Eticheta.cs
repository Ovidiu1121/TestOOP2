using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2.figuri
{
    public class Eticheta:IFigura,IComparable<Eticheta>
    {
        private Linie linie1;
        private Linie linie2;
        private string text;

        public Eticheta()
        {

        }

        public Eticheta(Linie linie1,Linie linie2,string text)
        {
            this.linie1 = linie1;
            this.linie2 = linie2;
            this.text = text;
        }

        public Linie Linie1
        {
            get { return this.linie1; }
            set { this.linie1 = value; }
        }

        public Linie Linie2
        {
            get { return this.linie2; }
            set { this.linie2 = value; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public override string ToString()
        {
            string text = "eticheta:\n";

            text+=this.linie1+" ";
            text+=this.linie2+" ";
            text+="text:"+this.text+" ";

            return text;
        }

        public override bool Equals(object? obj)
        {
            Eticheta eticheta=obj as Eticheta;

            if (eticheta.Linie1.Punct1.X.Equals(this.linie1.Punct1.X))
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
            this.linie1.Punct1.translatare(x, y);
            this.linie1.Punct2.translatare(x, y);
            this.linie2.Punct1.translatare(x, y);
            this.linie2.Punct2.translatare(x, y);
        }

        public IFigura duplicare()
        {
            return new Eticheta(this.linie1, this.linie2, this.text);
        }

        public int CompareTo(Eticheta? other)
        {
            if (this.linie1.Punct1.X>other.linie1.Punct1.X)
            {
                return 1;
            }
            else if (this.linie1.Punct1.X<other.linie1.Punct1.X)
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
