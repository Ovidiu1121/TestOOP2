using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2
{
    public class Punct:IFigura ,IComparable<Punct>
    {
        private int x;
        private int y;

        public Punct()
        {

        }

        public Punct(int x, int y)
        {
            this.x=x;
            this.y=y;
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public override string ToString()
        {
            string text = "punct=>  ";

            text+="x="+this.x+" ";
            text+="y="+this.y+" ";

            return text;

        }

        public override bool Equals(object? obj)
        {
            Punct punct = obj as Punct;

            if (punct.X.Equals(this.x)&&punct.Y.Equals(this.y))
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
            this.x += x;
            this.y += y;
        }

        public IFigura duplicare()
        {
            return new Punct(this.x, this.y);
        }

        public int CompareTo(Punct? other)
        {

            if (this.x>other.x)
            {

                return 1;
            }
            else if(this.x<other.y)
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
