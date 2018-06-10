public class LightOffCommand : Command {
    Light light;

    public LightOffCommand(Light light) {
        light = light;
    }

    public void execute() {
        light.off();
    }
    
    public void undo() {
        light.on();
    }
}