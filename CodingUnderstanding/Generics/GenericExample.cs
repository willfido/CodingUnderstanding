using System;
using System.Text;

namespace CodingUnderstanding.Generics
{
    class ObjectGeneric<T, U>
    {
        T A { get; set; }
        U B { get; set; }

        public ObjectGeneric(T a, U b) { A = a; B = b; }

        public string DisplayValues()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.GetType()).Append("\n\r")
              .Append("Value A = ")
              .Append(A.ToString()).Append("\n\r")
              .Append("Value B = ")
              .Append(B.ToString()).Append("\n\r");

            return sb.ToString();
        }

        public string DisplayPropertyValues()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Value A = ")
              .Append(A.ToString()).Append("\n\r")
              .Append("Value B = ")
              .Append(B.ToString()).Append("\n\r");

            return sb.ToString();
        }
    }

    class GenericExample
    {
        public GenericExample()
        {
            ObjectGeneric<int, int> intInt = new ObjectGeneric<int, int>(1, 2);
            ObjectGeneric<int, string> intString = new ObjectGeneric<int, string>(1, "Banana");
            ObjectGeneric<string, float> StringFloat = new ObjectGeneric<string, float>("Apples", 5.0f);

            Console.WriteLine(intInt.DisplayValues());
            Console.WriteLine(intString.DisplayValues());
            Console.WriteLine(StringFloat.DisplayValues());
        }
    }
}
