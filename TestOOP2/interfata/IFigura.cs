using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP2
{
    public interface IFigura
    {

        void afisare();

        void translatare(int x, int y);

        IFigura duplicare();


    }

}
