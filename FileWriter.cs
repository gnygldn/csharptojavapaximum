using System.Collections.Generic;
using System.Reflection;
using CSharpReflection;
using ReflectionTraining2;

namespace gny.FromCSharpToJava
{
    public class FileWriter
    {
        private string location;
        private Elements myElements;
        private string packageName;


        public FileWriter(string location, Elements sourceFile,string packageName)
        {
            this.location = location;
            myElements = sourceFile;
            this.packageName = packageName;
        }

        public void Write()
        {
            new ClassWriter(location, myElements.classList, packageName);
            new EnumWriter(location, myElements.enumList,packageName);
            new StructWriter(location, myElements.structList, packageName);
        }
    }
}