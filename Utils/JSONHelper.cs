using System.Text.Json;

namespace StatsTracker.Utils;

public static class JSONHelper
{
    public static T? LoadFromJsonFile<T>(string filePath)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            string jsonString = sr.ReadToEnd();
            T? json = JsonSerializer.Deserialize<T>(jsonString);

            if (json != null)
            {
                return json;
            }
        }
        
        return default;
    }

    public static void SaveToJsonFile<T>(string filePath, T? objectToSave)
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            string jsonString = JsonSerializer.Serialize(objectToSave);
            sw.Write(jsonString);
        }
    }
}