using NUnit.Framework;

namespace CodingUnderstanding.Generics.Test
{
    public class GenericsTest
    {
        [Test]
        public void test_GenericIntInt()
        {

            ObjectGeneric<int, int> genericIntInt = new ObjectGeneric<int, int>(1, 2);
            ObjectIntInt intInt = new ObjectIntInt(1, 2);

            Assert.AreEqual(genericIntInt.DisplayValues(), intInt.DisplayValues());
        }

        [Test]
        public void test_GenericIntString()
        {
            ObjectGeneric<int, string> genericintString = new ObjectGeneric<int, string>(1, "Banana");
            ObjectIntString intInt = new ObjectIntString(1, "Banana");

            Assert.AreEqual(genericintString.DisplayValues(), intInt.DisplayValues());
        }

        [Test]
        public void test_GenericStringFloat()
        {
            ObjectGeneric<string, float> genericStringFloat = new ObjectGeneric<string, float>("Apples", 5.0f);
            ObjectStringFloat intInt = new ObjectStringFloat("Apples", 5.0f);

            Assert.AreEqual(genericStringFloat.DisplayValues(), intInt.DisplayValues());
        }
    }
}
