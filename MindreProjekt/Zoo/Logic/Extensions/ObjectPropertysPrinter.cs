
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.Attributes;

namespace Logic.Extensions
{
    public static class ObjectPropertysPrinter
    {
     
            /// <summary>
            /// Listar ett objekts alla egenskaper i konsolen, kräver att propertyn har ett translate attribut för att egenskapen ska listas.
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public static string ObjectPropertys(this object obj)
            {

                
                var props = obj.GetType().GetProperties();
            
                var sb = new StringBuilder();

                foreach (var p in props.Reverse())
                {
                Translate translate = (Translate)Attribute.GetCustomAttribute(p, typeof(Translate));
                if (translate != null)
                {
                    sb.AppendLine($"{translate.Name}: {p.GetValue(obj, null)} {translate.Extra}");
                }

                }
                return sb.ToString();
            }
        
    }
}

