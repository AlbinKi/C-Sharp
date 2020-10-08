using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Reflection;
using CustomAttribute;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Konverterar en sträng till vald datatyp. Skickar ut felmeddelande och försöker igen tills inmatningen är korrekt.
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
                    catch (FormatException)
                    {
                        Console.WriteLine("Felinmatning försök igen.");
                        userinput = Console.ReadLine();
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// Listar ett objekts alla properties i konsolen, kräver att propertyn har ett attribut För att kunna skriva ut korrekta namnen på resultatet.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PropertyList(this object obj)
        {
            var props = obj.GetType().GetProperties();
            var sb = new StringBuilder();

            foreach (var p in props.Reverse())
            {
                Translate word = (Translate)Attribute.GetCustomAttribute(p, typeof(Translate));

                if (word == null)
                {
                    //Innebär att Egenskapen inte har något attribute med ett alternativnamn
                    Console.WriteLine("Okänd egenskap");
                } else
                {
                    sb.AppendLine($"{word.Name}: {p.GetValue(obj, null)} {word.Extra}");
                }   
            }
            return sb.ToString();
        }

        public static bool ToBool(this string value)
        {
            var invalidanswer = true;
            var result = true;
            while (invalidanswer)
            if (value.ToLower() == "ja")
            {
                result = true;
                invalidanswer = false;
            }
            else if (value.ToLower() == "nej") 
            {
                result = false;
                invalidanswer = false;
            } else
                {
                    Console.WriteLine("Svara antingen ja eller nej");
                    value = Console.ReadLine();
                }
            

            return result;

        }

        /// <summary>
        /// Väljer vilka Barn av Föräldern som ska skrivas ut. Alternativt "Förälder, Förälder" För att få ut hela listan.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listtoprint"></param>
        public static void PrintListProperties<T, K>(this List<K> listtoprint)
        {
            foreach (var e in listtoprint)
            {
                if (e is T)
                {
                    Console.WriteLine(e.PropertyList());
                }
            }
        }

        /// <summary>
        /// Returnerar ett objekt baserat på om användarinmatningen överensstämmer med propertyns värde. 
        /// </summary>
        /// <typeparam name="Children"></typeparam>
        /// <typeparam name="Parent"></typeparam>
        /// <param name="objectlist"></param>
        /// <param name="userinput"></param>
        /// <param name="propertyid"></param>
        /// <returns></returns>

        public static object GetObjectFromList<T, K>(this List<K> objectlist, string userinput, string propertyid)
        {


          foreach (var e in objectlist)
            {
                if (e is T)
                {
                    if (e.GetType().GetProperty(propertyid).GetValue(e).ToString().ToLower().Replace(" ", "") == userinput.ToLower().Replace(" ", ""))
                    {
                        return e;
                    }
                }
            }
            return null;
        }




    }
}
