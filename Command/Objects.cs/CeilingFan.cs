public class CeilingFan {
    public enum Speed {
        HIGH, MEDIUM, LOW, OFF
    }

    Speed speed;

    public CeilingFan() {
        speed = Speed.OFF;
    }
}