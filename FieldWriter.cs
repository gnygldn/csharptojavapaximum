using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpReflection;
using gny.FromCSharpToJava;
using ReflectionTraining2;

namespace ReflectionTraining2
{
    public class FieldWriter
    {
        public void WriteField(NewPageCreator page, List<FieldElements> fields)
        {
            foreach (var field in fields)
            {
                ReturnTypeProvider returnType = new ReturnTypeProvider();
                string fieldReturnType = returnType.GetReturnType(field.FieldType);
                page.StreamWriter.WriteLine("\t" + "public" + " " + fieldReturnType + " " + field.fieldName + ";\n");
            }
        }
    }
}