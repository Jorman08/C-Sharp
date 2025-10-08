namespace POOWorkshop.Services.Output;

public class FileOutput : IOutput
{
    private readonly string _path;
    public FileOutput(string path) => _path = path;

    public void WriteLine(string text) => File.AppendAllText(_path, text + Environment.NewLine);
}
