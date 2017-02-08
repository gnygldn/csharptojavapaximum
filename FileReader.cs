using System;
using System.Reflection;

namespace gny.FromCSharpToJava
{
    public class FileReader
    {
        public Assembly SourceFile { get; set; }

        public FileReader(string sourceLocation)
        {
            SourceFile = GetSourceFile(sourceLocation);
        }

        public Assembly GetSourceFile(string sourceLocation)
        {
            return Assembly.LoadFile(sourceLocation);
        }

        public Type[] GetTypes()
        {
            return SourceFile.GetTypes();
        }
    }
}