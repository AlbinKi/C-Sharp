using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Konverterar en sträng till vald datatyp och skickar ett felmeddelande tills datatypen matchar.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="userinput"></param>
        /// <returns></returns>
        public static T Parse<T>(this string userinput)
        {
            T result = default(T);
            while (EqualityComparer<T>.Default.Equals(result, default(T)))
            {
                if (!String.IsNullOrEmpty(userinput))
                {
                    TypeConverter tc = TypeDescriptor.GetConverter(typeof(T));

                    try
                    {
                        result = (T)tc.ConvertFrom(userinput);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Felinmatning försök igen.");
                        userinput = Console.ReadLine();                     
                    }
                }
            }
            return result;
        }

        public static string PropertyList(this object obj)
        {
            var props = obj.GetType().GetProperties();
            
            var sb = new StringBuilder();
            var firstloop = true;
            foreach (var p in props)
            {
                if (!firstloop)
                {
                    sb.AppendLine($"{p.Name}: {p.GetValue(obj, null)}");
                }
                firstloop = false;
                }
            return sb.ToString();
        }
    }
}
