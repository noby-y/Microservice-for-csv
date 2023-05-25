using ChoETL;
using System.Text;

public class CSVService
{
    public static string ConvertToJson(IFormFile file)
    {
        StringBuilder json = new StringBuilder();
        using (var csvReader = ChoCSVReader.LoadText(ReadAsString(file))
        .WithFirstLineHeader()
        .WithDelimiter(";")
        .IgnoreEmptyLine()
        .IgnoreFieldValueMode(ChoIgnoreFieldValueMode.WhiteSpace)
        .ThrowAndStopOnMissingField(false)
        )
        {
            using (var csvWriter = new ChoJSONWriter(json))
                csvWriter.Write(csvReader);
        }
        return json.ToString();
    }

    public static string ReadAsString(IFormFile file)
    {
        using (var reader = new StreamReader(file.OpenReadStream()))
        {
            return reader.ReadToEnd();
        }
    }
}