using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade facade = new HomeTheaterFacade(new DvdPlayer(), new Lights());
            facade.watchMovie();
            facade.endMovie();
        }
    }
}
