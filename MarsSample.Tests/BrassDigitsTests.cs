using System;
using NUnit.Framework;

namespace MarsSample.Tests
{
    [TestFixture]
    public class BrassDigitsTests
    {
        private Program _program;

        [OneTimeSetUp]
        public void Init()
        {
            /* ... */
            _program = new Program();
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            /* ... */
            _program = null;
        }

        [Test]
        public void BrassDigits200()
        {
            var expected = new[] {31, 140, 41, 40, 40, 40, 40, 40, 40, 40};

            var actual = _program.BrassDigits(200);

            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
            for (var i = 0; i < actual.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, actual[i]);
            }
        }

        [Test]
        public void BrassDigits500()
        {
            var expected = new[] {91, 200, 200, 200, 200, 101, 100, 100, 100, 100};
            var actual = _program.BrassDigits(500);

            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
            for (var i = 0; i < actual.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, actual[i]);
            }
        }

        [Test]
        public void BrassDigitsArgumentOutOfRangeException10Pow19()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _program.BrassDigits(Math.Pow(10, 19)));
        }

        [Test]
        public void BrassDigitsArgumentOutOfRangeException0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _program.BrassDigits(0));
        }

        [Test]
        public void BrassDigitsArgumentOutOfRangeException_1()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _program.BrassDigits(-1));
        }

        [Test]
        public void C3BrassDigits10Pow12()
        {
            var actual = _program.BrassDigits(Math.Pow(10, 12));

            Assert.IsNotNull(actual);
            for (var i = 0; i < actual.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, actual[i]);
            }
        }

        [Test]
        public void C2BrassDigits10Pow9()
        {
            var expected = new[] { 788888898, 900000001, 900000000, 900000000, 900000000, 900000000, 100900000000, 900000000, 900000000, 900000000 };
            var actual = _program.BrassDigits(Math.Pow(10, 9));

            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
            for (var i = 0; i < actual.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, actual[i]);
            }
        }

        [Test]
        public void C1BrassDigits10Pow8()
        {
            var expected = new[] { 68888897, 80000001, 80000000, 80000000, 80000000, 80000000, 80000000, 80000000, 80000000, 80000000 };

            var actual = _program.BrassDigits(Math.Pow(10, 8));

            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
            for (var i = 0; i < actual.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, actual[i]);
            }
        }
    }
}