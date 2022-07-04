using System.Dynamic;
using System.Reflection;
using Microsoft.VisualStudio;
using System.Linq;
namespace JSON_Serializer;
public class Serializer
{

    public string Serialize(object obj) {
        Type type = obj.GetType();
        string jsonString = string.Empty;
        if (type == typeof(int) || type == typeof(decimal)) return obj.ToString();
        if (type == typeof(string) || type == typeof(char)) return $"\"{obj}\"";
        if (type == typeof(bool)) return obj.ToString().ToLower();
        if (obj is List<object> list) {
            string result = string.Empty;
            foreach (var elem in list) {
                result += Serialize(elem) + ",";
            }

            return "[" + result.Remove(result.Length - 1) + "]";
        }

        if (obj is Dictionary<string, object> dict) {
            foreach (KeyValuePair<string, object> elem in dict) {
                jsonString += $"\"{elem.Key}\":{Serialize(elem.Value)},";
               
            }
            return "{" + jsonString.Remove(jsonString.Length - 1) + "}";
        }
        
        return "{" + jsonString.Remove(jsonString.Length) + "}";
}
}