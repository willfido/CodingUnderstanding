using NUnit.Framework;

namespace CodingUnderstanding.Generics.Test
{
    public class GenericsTest
    {
        [Test]
        public void test_GenericIntInt()
        {

            var genericIntInt = new ObjectGeneric<int, int>(1, 2);
            var intInt = new ObjectIntInt(1, 2);


            Assert.AreEqual(genericIntInt.DisplayPropertyValues(), intInt.DisplayPropertyValues());
        }

        [Test]
        public void test_GenericIntString()
        {
            var genericintString = new ObjectGeneric<int, string>(1, "Banana");
            var intString = new ObjectIntString(1, "Banana");

            Assert.AreEqual(genericintString.DisplayPropertyValues(), intString.DisplayPropertyValues());
        }

        [Test]
        public void test_GenericStringFloat()
        {
            var genericStringFloat = new ObjectGeneric<string, float>("Apples", 5.0f);
            var stringFloat = new ObjectStringFloat("Apples", 5.0f);

            Assert.AreEqual(genericStringFloat.DisplayPropertyValues(), stringFloat.DisplayPropertyValues());
        }
    }
}
