namespace Command
{
    public class CeilingFan {
        public enum Speed {
            HIGH, MEDIUM, LOW, OFF
        }

        public Speed speed;

        public CeilingFan() {
            speed = Speed.OFF;
        }
    }
}