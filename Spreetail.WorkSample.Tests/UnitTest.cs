using NUnit.Framework;
using Spreetail.WorkSample.Source.Repository;
using System.Linq;

namespace Spreetail.WorkSample.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddMethod()
        {
            IDataRepository dr = new DataRepository();
            dr.Add("foo", "bar");
            dr.Add("foo", "baz");
            dr.Add("name", "john");
            dr.Add("name", "doe");

            Assert.AreEqual(dr.Items().Count(), 4);
            Assert.AreEqual(dr.Items().Any(x => x.Value == "john"), true);
            Assert.AreEqual(dr.Items().Any(x => x.Value == "little"), false);
        }

        // To be Continued..
    }
}