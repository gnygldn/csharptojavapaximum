using System;
using System.Collections.Generic;
using CSharpReflection;
using gny.FromCSharpToJava;

namespace ReflectionTraining2
{
    public class StructWriter
    {
        public StructWriter(string location, List<StructElements> elements,string packageName)
        {
            foreach (var element in elements)
            {
                var newPage = new NewPageCreator(location + element.structName + ".java");
                newPage.StreamWriter.WriteLine("package" + " " + packageName + ";");
                newPage.StreamWriter.WriteLine("class" + " " + element.structName + " \n{");


                FieldWriter field = new FieldWriter();
                field.WriteField(newPage, element.structFields);


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