public class HomeTheaterFacade {
    DvdPlayer dvd;
    Lights lights;

    public HomeTheaterFacade(
        DvdPlayer dvd,
        Lights lights
    ) {
        dvd = dvd;
        lights = lights;
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