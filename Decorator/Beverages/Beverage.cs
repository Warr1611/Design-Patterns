namespace Decorator
{
    public abstract class Beverage {
        public enum Size {
            TALL, GRANDE, VENTI
        };
        public Size size = Size.TALL;
        public string description = "Unknown Beverage";

        public string getDescription() {
            return description;
        }

        public Size getSize() {
            return this.size;
        }

        public void setSize(Size size) {
            this.size = size;
        }

        public abstract double cost();
    }
}