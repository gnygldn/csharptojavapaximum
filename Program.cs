using gny.FromCSharpToJava;
using CSharpReflection;

namespace ReflectionTraining2
{
    class Program
    {
        static void Main()
        {
            AssemblyReader assembly = new AssemblyReader("C:/Users/gnygl/Desktop/projects/reflectionTrainings/CSharpToJava/c#toJava/ReflectionTraining2/bin/Debug/Paximum.Content.Messages.dll");
            TypeHandler typeHandler = new TypeHandler(assembly.GetAssembly());
            var elements = typeHandler.TypeSender();
            FileWriter fileWriter = new FileWriter("C:/Users/gnygl/Desktop/gnygldnm/", elements,"gnygldnm");
            fileWriter.Write();
        }
    }
}