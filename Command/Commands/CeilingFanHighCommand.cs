public class CeilingFanHighCommand : Command {
    CeilingFan fan;
    Speed prevSpeed;

    public CeilingFanHighCommand(CeilingFan fan) {
        fan = fan;
    }

    public void execute() {
        prevSpeed = fan.speed;
        fan.speed = Speed.HIGH;
        // Could move this to the CeilingFan with a setSpeed function
        Console.WriteLine("Fan High!");
    }

    public void undo() {
        switch(prevSpeed) {
            case Speed.HIGH:
                fan.speed = Speed.HIGH;
                break;
            case Speed.MEDIUM:
                fan.speed = Speed.MEDIUM;
                break;
            case Speed.LOW:
                fan.speed = Speed.LOW;
                break;
            case Speed.OFF:
                fan.speed = Speed.OFF;
                break;
            default:
                break;
        }
    }
}