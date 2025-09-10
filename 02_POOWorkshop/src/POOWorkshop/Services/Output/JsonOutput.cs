using System.Text.Json;

namespace POOWorkshop.Services.Output;

public class JsonOutput : IOutput
{
    private readonly string _filePath;
    private readonly List<string> _lines = new();

    public JsonOutput(string filePath)
    {
        _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
    }

    public void WriteLine(string text)
    {
        _lines.Add(text);
    }

    public void SaveToFile()
    {
        var jsonData = new { Timestamp = DateTime.Now, PayrollData = _lines };

        var json = JsonSerializer.Serialize(
            jsonData,
            new JsonSerializerOptions { WriteIndented = true }
        );

        File.WriteAllText(_filePath, json);
    }
}
