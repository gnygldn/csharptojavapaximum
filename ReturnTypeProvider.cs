using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ReflectionTraining2
{
    public class ReturnTypeProvider
    {
        public string GetReturnType(Type type)
        {
            if (type.IsPrimitive)
            {
                CSharpJavaValueTypesDictionary dictionary = new CSharpJavaValueTypesDictionary();
                return dictionary.SystemValueTypesDictionary[type.ToString()];
            }
            if (Nullable.GetUnderlyingType(type) != null)
            {
                if (Nullable.GetUnderlyingType(type).IsPrimitive)
                {
                    CSharpJavaValueTypesDictionary dictionary = new CSharpJavaValueTypesDictionary();

                    return dictionary.Nullables[Nullable.GetUnderlyingType(type).ToString()];
                }
                return GetReturnType(Nullable.GetUnderlyingType(type));
            }
            if (type == typeof(string))
            {
                return "String";
            }
            if (type.IsArray)
            {
                return GetReturnType(type.GetElementType()) + "[]";
            }
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                return GetReturnType(type.GetGenericArguments()[0]) + "[]";
            }
            if (type == typeof(DateTime))
            {
                return "Date";
            }
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(LinkedList<>))
            {
                return " /* for" + " " + GetReturnType(type.GetGenericArguments()[0]) + " " + "*/" + " " + "LinkedList";
            }
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ICollection<>))
            {
                return GetReturnType(type.GetGenericArguments()[0]) + "[]";
            }
            if (type.GetGenericArguments().Length == 2)
            {
                var typeArguments = type.GetGenericArguments();
                return "Map<" + GetReturnType(typeArguments[0]) + "," + GetReturnType(typeArguments[1]) + ">";
            }
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            {
                return GetReturnType(type.GetGenericArguments()[0]) + "[]";
            }

            return type.Name;
        }
    }
}