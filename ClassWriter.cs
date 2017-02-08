using System;
using System.Collections.Generic;
using CSharpReflection;
using gny.FromCSharpToJava;

namespace ReflectionTraining2
{
    class ClassWriter
    {
        public ClassWriter(string location, List<ClassElements> elements,string packageName)
        {
            WriteClasses(location, elements,packageName);
        }

        public void WriteClasses(string location, List<ClassElements> elements,string packageName)
        {
            foreach (var element in elements)
            {
                var newPage = new NewPageCreator(location + element.className + ".java");
                newPage.StreamWriter.WriteLine("package" + " " + packageName + ";");
                newPage.StreamWriter.WriteLine("public" + " class " + element.className + " \n{");
                FieldWriter field = new FieldWriter();
                field.WriteField(newPage, element.classFields);
                PropertyWriter property = new PropertyWriter();
                property.WriteProperty(newPage, element.classPropertys);
                ClosePage(newPage);
            }
        }

        private void ClosePage(NewPageCreator page)
        {
            page.StreamWriter.WriteLine("}");
            page.StreamWriter.Close();
            page.FileStream.Close();
        }
    }
}