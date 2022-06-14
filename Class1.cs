using System.Reflection;
using System.Text;
namespace JSON_Serializer;
public class Serializer
{
    
    public string Serialize(object obj)
    {
        string jsonString = "";
        List<string> props = new List<string>();
        Type type = obj.GetType();
    
        foreach (PropertyInfo elem in type.GetProperties())
        {
            object? value = elem.GetValue(obj);
            string textValue = value is string text ? $"\"{text.Replace("\"", "\\\"")}\"" : $"{value ?? "null"}";
            textValue = value is bool ? textValue.ToLower() : textValue;
            string currentPropertyFormat = $"\"{elem.Name}\":{textValue}";
            props.Add(currentPropertyFormat);
        }
        for (int i = 0; i < props.Count; i++)
        {
            jsonString += props[i];
            if (i != props.Count - 1)
                jsonString += ",";
        }
    
        return "{" + jsonString + "}";
    }
}