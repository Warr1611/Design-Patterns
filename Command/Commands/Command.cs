namespace Command
{
    public interface Command {
        // To change to using lambdas, need to remove undo method
        void execute();
        void undo();
    }
}