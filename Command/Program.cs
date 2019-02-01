using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl control = new RemoteControl();

            Light livingRoom = new Light();
            Light kitchen = new Light();
            CeilingFan fan = new CeilingFan();

            control.setCommand(0, new LightOnCommand(livingRoom), new LightOffCommand(livingRoom));
            control.setCommand(1, new LightOnCommand(kitchen), new LightOffCommand(kitchen));
            control.setCommand(2, new CeilingFanHighCommand(fan), new CeilingFanOffCommand(fan));

            control.onButtonPushed(0);
            control.offButtonPushed(0);
            control.onButtonPushed(1);
            control.offButtonPushed(1);
            control.onButtonPushed(2);
            control.offButtonPushed(2);
        }
    }
}
