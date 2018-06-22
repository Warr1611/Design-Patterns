public class TurkeyAdapter : Duck {
    Turkey turkey;

    public TurkeyAdapter(Turkey turkey) {
        turkey = turkey;
    }

    public void quack() {
        turkey.gobble();
    }

    public void fly() {
        for(int i = 0; i < 5; i++) {
            turkey.fly();
        }
    }
}