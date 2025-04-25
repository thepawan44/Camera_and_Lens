using System.Reflection;

namespace UI.Shared.UtilityHelpers
{
    public class UtilityHelper
    {
        public static Dictionary<string, object> ObjectToDictionary(object model)
        {
            Dictionary<string, object> Parameter = new();
            object val;
            foreach (PropertyInfo prop in model.GetType().GetProperties())
            {
                string propName = prop.Name;
                if (prop.PropertyType.Name.Contains("IEnumerable") && prop.PropertyType.FullName!.Contains("System.Int"))
                    val = string.Join(",", (IEnumerable<int>)prop.GetValue(model)!);
                else if (prop.PropertyType.Name.Contains("IEnumerable") && prop.PropertyType.FullName!.Contains("System.String"))
                    val = "'" + string.Join("','", (IEnumerable<string>)prop.GetValue(model)!) + "'";
                else
                    val = prop.GetValue(model)!;
                if (val != null)
                {
                    Parameter.Add(propName, val.ToString()!);
                }
            }
            return Parameter;
        }
    }
}
