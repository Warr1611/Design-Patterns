namespace Facade
{
    public class HomeTheaterFacade {
        DvdPlayer dvd;
        Lights lights;

        public HomeTheaterFacade(
            DvdPlayer dvd,
            Lights lights
        ) {
            this.dvd = dvd;
            this.lights = lights;
        }

        public void watchMovie() {
            dvd.on();
            lights.dim();
            dvd.play();
        }

        public void endMovie() {
            dvd.off();
            lights.on();
        }
    }
}