public class LightOnCommand : Command {
    Light light;

    public LightOnCommand(Light light) {
        light = light;
    }

    public void execute() {
        light.on();
    }
    
    public void undo() {
        light.off();
    }
}