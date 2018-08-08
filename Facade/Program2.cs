public void Main () {
    HomeTheaterFacade facade = new HomeTheaterFacade(new DvdPlayer(), new Lights());
    facade.watchMovie();
    facade.endMovie();
}