var buttomMaster = new ButtonMaster();

buttomMaster.ButtomPreessed += (sender, args) =>
{
    Console.WriteLine($"Button {args.KeyCode} pressed");
};

buttomMaster.ButtomPreessed += (sender, args) =>
{
    Console.WriteLine($"Button {args.KeyCode} pressed from differente handler");
};

Start:

var keyCode = Console.ReadKey(true).KeyChar;
buttomMaster.OnButtonPressed(keyCode);

goto Start;