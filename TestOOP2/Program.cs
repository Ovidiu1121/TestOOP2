



using TestOOP2;
using TestOOP2.figuri;

class Program
{
    static void Main(string[] args)
    {

        List<IFigura> lista = new List<IFigura>();

        Punct punct1=new Punct(10,30);
        Punct punct2 = new Punct(5, 30);
        Linie linie1=new Linie(new Punct(20,20),new Punct(100,35));
        Cerc cerc = new Cerc(new Punct(40, 15), new Linie(new Punct(15, 60), new Punct(40, 5)));
        Dreptunghi dreptunghi = new Dreptunghi(new Linie(new Punct(25, 40), new Punct(70, 20)), new Linie(new Punct(35, 10),new Punct(60,50)));
        Eticheta eticheta = new Eticheta(linie1, new Linie(new Punct(80, 100), new Punct(20, 90)), "pret produs");

        lista.AddRange(new List<IFigura> { linie1,cerc,dreptunghi,eticheta});

        Desen desen = new Desen(lista);

        desen.afisare();

        desen.translatare(2, 4);

        desen.afisare();

    }

}