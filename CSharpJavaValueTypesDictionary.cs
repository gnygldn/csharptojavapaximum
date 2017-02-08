using System.Collections.Generic;

namespace ReflectionTraining2
{
    public class CSharpJavaValueTypesDictionary
    {
        public Dictionary<string, string> SystemValueTypesDictionary = new Dictionary<string, string>();
        public Dictionary<string,string> Nullables = new Dictionary<string, string>();

        public CSharpJavaValueTypesDictionary()
        {
            SystemValueTypesDictionary.Add("System.String", "String");
            SystemValueTypesDictionary.Add("System.Int32", "int");
            SystemValueTypesDictionary.Add("System.Decimal", "double");
            SystemValueTypesDictionary.Add("System.Double", "double");
            SystemValueTypesDictionary.Add("System.Object", "obj");
            SystemValueTypesDictionary.Add("System.Char", "char");
            SystemValueTypesDictionary.Add("System.Boolean", "boolean");
            SystemValueTypesDictionary.Add("System.Single", "float");
            SystemValueTypesDictionary.Add("System.UInt64", "long");
            SystemValueTypesDictionary.Add("System.Int64", "long");
            SystemValueTypesDictionary.Add("System.UInt16", "short");
            SystemValueTypesDictionary.Add("System.Int16", "short");
            SystemValueTypesDictionary.Add("System.UInt32", "int");
            SystemValueTypesDictionary.Add("System.SByte", "sbyte");
            SystemValueTypesDictionary.Add("System.Byte", "byte");
            Nullables.Add("System.String", "String");
            Nullables.Add("System.Int32", "Integer");
            Nullables.Add("System.Decimal", "Double");
            Nullables.Add("System.Double", "Double");
            Nullables.Add("System.Object", "Object");
            Nullables.Add("System.Char", "Character");
            Nullables.Add("System.Boolean", "Boolean");
            Nullables.Add("System.Single", "Double");
            Nullables.Add("System.UInt64", "Long");
            Nullables.Add("System.Int64", "Long");
            Nullables.Add("System.UInt16", "Short");
            Nullables.Add("System.Int16", "Short");
            Nullables.Add("System.UInt32", "Integer");
            Nullables.Add("System.SByte", "Byte");
            Nullables.Add("System.Byte", "Byte");
        }
    }
}