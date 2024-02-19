using System.Text;

namespace ReflectionApp
{    
    /// <summary>
    /// кастомный сериализатор
    /// </summary>
    internal static class Serializator
    {
        private const string separator = ";";

        /// <summary>
        /// сериализация класса F в строку
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static string Serialize(this F f)
        {            
            StringBuilder ss = new StringBuilder();
            
            foreach (var field in f.GetType().GetFields())
            {
                var value = field.GetValue(f);
                
                if (value != null)                                                        
                    ss.AppendLine($"{field.Name}{separator}{value}");                 
                else
                    ss.AppendLine($"{field.Name}{separator}{0}");
            }

            return ss.ToString();
        }

        /// <summary>
        /// десериализация класса F из строки
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static F DeSerializeF(this string s)
        {
            StringReader strReader = new StringReader(s);

            F ff = new F();
            var fields = ff.GetType().GetFields();

            string line = string.Empty;

            while (true)
            {
                line = strReader.ReadLine();
                if (line != null)
                {
                    var item = line.Substring(0, line.IndexOf(separator));
                    line = line.Replace(item,"");
                    line = line.Replace(separator, "");
                    var value = Convert.ToInt32(line);

                    var field = fields.Where(x => x.Name == item).FirstOrDefault();
                    if (field != null)                    
                        field.SetValue(ff, value);                    
                }
                else                                    
                    break;                
            }

            return ff;
        }
    }
}
