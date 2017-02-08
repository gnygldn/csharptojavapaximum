using System.IO;
using CSharpReflection;

namespace gny.FromCSharpToJava
{
    public class NewPageCreator
    {
        public FileStream FileStream;
        public StreamWriter StreamWriter;

        public NewPageCreator(string location)
        {
            FileStream = CreateNewJavaFile(location);
            StreamWriter = new StreamWriter(FileStream);
        }

        public FileStream CreateNewJavaFile(string location)
        {
            return new FileStream(location, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }
    }
}