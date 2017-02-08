using System.Collections.Generic;
using CSharpReflection;

namespace gny.FromCSharpToJava
{
    public class EnumWriter
    {
        public EnumWriter(string location, List<EnumElements> elements, string packageName)
        {
            WriteEnums(location, elements,packageName);
        }

        private void WriteEnums(string location, List<EnumElements> elements,string packageName)
        {
            foreach (var element in elements)
            {
                var newPage = new NewPageCreator(location + element.enumName + ".java");
                newPage.StreamWriter.WriteLine("package" + " " + packageName + ";");
                newPage.StreamWriter.Write("public enum" + " " + element.enumName + " \n{");

                foreach (var enumValues in element.enumFields)
                {
                    newPage.StreamWriter.Write("\n \t" + enumValues.enumValue + "(" + enumValues.enumNumberValue + ")" +
                                               ",");
                }
                newPage.StreamWriter.Write("; \n");
                newPage.StreamWriter.WriteLine("\t" + "private int value; \n");
                newPage.StreamWriter.WriteLine("\t" + element.enumName + "( int i ) {\n \t \t this.value = i; \n    }");

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