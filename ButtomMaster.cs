public class ButtonMaster
{
    public event EventHandler<ButtomPressedEventArgs>? ButtomPreessed;

    public void OnButtonPressed(char keyCode)
    {
        ButtomPreessed?.Invoke(this, new ButtomPressedEventArgs(keyCode));
    }
}

public class ButtomPressedEventArgs
{
    public ButtomPressedEventArgs(char keyCode)
    {
        KeyCode = keyCode;
    }

    public char KeyCode { get; }
}