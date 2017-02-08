using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CSharpReflection;
using gny.FromCSharpToJava;

namespace ReflectionTraining2
{
    public class PropertyWriter
    {
        public void WriteProperty(NewPageCreator page, List<PropertyElements> properties)
        {
            foreach (var property in properties)
            {
                ReturnTypeProvider returnType = new ReturnTypeProvider();
                string propertyReturnType = returnType.GetReturnType(property.propertyType);
                page.StreamWriter.WriteLine("\t" + "public" + " " + propertyReturnType + " " + property.propertyName + ";");
            }
        }
    }
}