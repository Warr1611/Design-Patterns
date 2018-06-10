public interface Command {
    // To change to using lambdas, need to remove undo method
    public void execute();
    public void undo();
}