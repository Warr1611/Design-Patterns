public class CeilingFanOffCommand : Command {
    CeilingFan fan;
    Speed prevSpeed;

    public CeilingFanOffCommand(CeilingFan fan) {
        fan = fan;
    }

    public void execute() {
        prevSpeed = fan.speed;
        fan.speed = Speed.OFF;
        // Could move this to the CeilingFan with a setSpeed function
        Console.WriteLine("Fan Off!");
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