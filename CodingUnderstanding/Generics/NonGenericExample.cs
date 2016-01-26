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
            var carriageReturnLineFeed = "\n\r";
            const string carriageReturnLineFeed = "\n\r";

            var sb = new StringBuilder();

            sb.Append(this.GetType()).Append(carriageReturnLineFeed)
              .Append("Value A = ")
              .Append(A.ToString()).Append(carriageReturnLineFeed)
              .Append("Value B = ")
              .Append(B.ToString()).Append(carriageReturnLineFeed);

            return sb.ToString();
        }

        public string DisplayPropertyValues()
        {

            const string carriageReturnLineFeed = "\n\r";

            var sb = new StringBuilder();

            sb.Append("Value A = ")
              .Append(A.ToString()).Append(carriageReturnLineFeed)
              .Append("Value B = ")
              .Append(B.ToString()).Append(carriageReturnLineFeed);

            return sb.ToString();
        }
    }

    internal class ObjectIntString
    {

        private int A { get; set; }
        private string B { get; set; }

        public ObjectIntString(int a, string b) { A = a; B = b; }

        public string DisplayValues()
        {
            var sb = new StringBuilder();

            sb.Append(this.GetType()).Append("\n\r")
              .Append("Value A = ")
              .Append(A.ToString()).Append("\n\r")
              .Append("Value B = ")
              .Append(B.ToString()).Append("\n\r");

            return sb.ToString();
        }

        public string DisplayPropertyValues()
        {
            const string carriageReturnLineFeed = "\n\r";

            var sb = new StringBuilder();

            sb.Append("Value A = ")
              .Append(A.ToString()).Append(carriageReturnLineFeed)
              .Append("Value B = ")
              .Append(B.ToString()).Append(carriageReturnLineFeed);

            return sb.ToString();
        }
    }

    class ObjectStringFloat
    {

        private string A { get; set; }
        private float B { get; set; }

        public ObjectStringFloat(string a, float b) { A = a; B = b; }

        public string DisplayValues()
        {
            var sb = new StringBuilder();

            sb.Append(this.GetType()).Append("\n\r")
              .Append("Value A = ")
              .Append(A).Append("\n\r")
              .Append("Value B = ")
              .Append(B).Append("\n\r");

            return sb.ToString();
        }

        public string DisplayPropertyValues()
        {

            const string carriageReturnLineFeed = "\n\r";

            var sb = new StringBuilder();

            sb.Append("Value A = ")
              .Append(A.ToString()).Append(carriageReturnLineFeed)
              .Append("Value B = ")
              .Append(B).Append(carriageReturnLineFeed);

            return sb.ToString();
        }
    }

    internal class NonGenericExample
    {
        public NonGenericExample()
        {

            var intInt = new ObjectIntInt(1, 2);
            var intString = new ObjectIntString(1, "Banana");
            var stringFloat = new ObjectStringFloat("Apples", 5.0f);

            Console.WriteLine(intInt.DisplayValues());
            Console.WriteLine(intString.DisplayValues());
            Console.WriteLine(stringFloat.DisplayValues());
        }
    }
}
