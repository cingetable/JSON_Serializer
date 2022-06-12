using System.Reflection;

namespace JSON_Serializer;

public class Serializer
{
    public string Serialize(object obj)
    {
        List<string> props = new List<string>();
        Type type = obj.GetType();
    
        foreach (PropertyInfo elem in type.GetProperties())
        {
            string currentPropertyFormat = $"\u0022{elem.Name}\u0022:{elem.GetValue(obj)}";
            props.Add(currentPropertyFormat);
        }
    
        string jsonString = "";
        for (int i = 0; i < props.Count; i++)
        {
            jsonString += props[i];
            if (i != props.Count - 1)
                jsonString += ",";
        }
    
        return "{" + jsonString + "}";
    }
}