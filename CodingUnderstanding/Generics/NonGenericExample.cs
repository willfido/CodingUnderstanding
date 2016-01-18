using System;
using System.Text;

namespace CodingUnderstanding.Generics
{
    class ObjectIntInt
    {

        int A { get; set; }
        int B { get; set; }

        public ObjectIntInt(int a, int b) { A = a; B = b; }

        public string DisplayValues()
        {

            string carriageReturnLineFeed = "\n\r";

            StringBuilder sb = new StringBuilder();

            sb.Append(this.GetType()).Append(carriageReturnLineFeed)
              .Append("Value A = ")
              .Append(A.ToString()).Append(carriageReturnLineFeed)
              .Append("Value B = ")
              .Append(B.ToString()).Append(carriageReturnLineFeed);

            return sb.ToString();
        }
    }

    class ObjectIntString
    {

        int A { get; set; }
        string B { get; set; }

        public ObjectIntString(int a, string b) { A = a; B = b; }

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
    }

    class ObjectStringFloat
    {

        string A { get; set; }
        float B { get; set; }

        public ObjectStringFloat(string a, float b) { A = a; B = b; }

        public string DisplayValues()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.GetType()).Append("\n\r")
              .Append("Value A = ")
              .Append(A).Append("\n\r")
              .Append("Value B = ")
              .Append(B.ToString()).Append("\n\r");

            return sb.ToString();
        }
    }

    class NonGenericExample
    {
        public NonGenericExample()
        {

            ObjectIntInt intInt = new ObjectIntInt(1, 2);
            ObjectIntString intString = new ObjectIntString(1, "Banana");
            ObjectStringFloat stringFloat = new ObjectStringFloat("Apples", 5.0f);

            Console.WriteLine(intInt.DisplayValues());
            Console.WriteLine(intString.DisplayValues());
            Console.WriteLine(stringFloat.DisplayValues());
        }
    }
}
