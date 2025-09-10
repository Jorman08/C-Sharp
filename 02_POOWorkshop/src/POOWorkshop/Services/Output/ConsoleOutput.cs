namespace POOWorkshop.Services.Output;

public class ConsoleOutput : IOutput
{
    public void WriteLine(string text) => Console.WriteLine(text);
}
