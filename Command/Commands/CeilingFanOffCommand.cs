using System;

namespace Command
{
    public class CeilingFanOffCommand : Command {
        CeilingFan fan;
        CeilingFan.Speed prevSpeed;

        public CeilingFanOffCommand(CeilingFan fan) {
            this.fan = fan;
        }

        public void execute() {
            prevSpeed = fan.speed;
            fan.speed = CeilingFan.Speed.OFF;
            // Could move this to the CeilingFan with a setSpeed function
            Console.WriteLine("Fan Off!");
        }

        public void undo() {
            switch(prevSpeed) {
                case CeilingFan.Speed.HIGH:
                    fan.speed = CeilingFan.Speed.HIGH;
                    break;
                case CeilingFan.Speed.MEDIUM:
                    fan.speed = CeilingFan.Speed.MEDIUM;
                    break;
                case CeilingFan.Speed.LOW:
                    fan.speed = CeilingFan.Speed.LOW;
                    break;
                case CeilingFan.Speed.OFF:
                    fan.speed = CeilingFan.Speed.OFF;
                    break;
                default:
                    break;
            }
        }
    }
}