using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2.figuri
{
    public class Desen:IFigura
    {
       
        private List<IFigura> lista;

        public Desen(List<IFigura>lista)
        {
           this.lista = lista;
        }

        public override string ToString()
        {
            string text = "";

            foreach(IFigura f in lista)
            {
                text+=f.ToString()+"\n";
            }
            return text;
        }

        public void afisare()
        {
            Console.WriteLine(this);
        }

        public IFigura duplicare()
        {
            return this;
        }

        public void translatare(int x, int y)
        {
            foreach(IFigura f in lista)
            {
                f.translatare(x, y);
            }
        }
    }
}
