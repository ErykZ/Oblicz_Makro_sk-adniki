using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oblicz_Makro_składniki;

namespace Makro_składniki_test
{
    [TestClass]
    public class BrainTest
    {
        [TestMethod]
        public void Test_Zwroc_wynik()
        {
            // Arrange
            Brain oblicz_test = new Brain();
            oblicz_test.Waga = 49;
            oblicz_test.Wzrost = 163;
            oblicz_test.Wiek = 26;
            // ACT
            oblicz_test.Zwroc_wynik();

            //Assert
            Assert.AreEqual(1379.72, oblicz_test.Wynik);
        }
        [TestMethod]
        public void Test_Zwroc_CalkowitaPrzeminaMaterii()
        {
            Brain oblicz_test = new Brain();
            oblicz_test.Wynik = 1500;
            oblicz_test.Is_men = true;

            double result = oblicz_test.Zwroc_CalkowitaPrzeminaMaterii(2);

            Assert.AreEqual(1800, result);
        }
        /*[TestMethod]
        public void Test_Zwroc_CalkowitaPrzeminaMateri()
        {
            // Arrange
            Brain oblicz_test = new Brain();

            // Act
            double CPM_test = oblicz_test.Zwroc_CalkowitaPrzeminaMaterii(1);

            // Assert
            Assert.AreEqual()

        }
        */


    }
}
