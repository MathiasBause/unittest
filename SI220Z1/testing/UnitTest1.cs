using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSaludar()
        {
            //Organizar
            SI220Z1.Saludar obj = new SI220Z1.Saludar();
            String valoresperado = "HOLA MUNDO";
            //Actuar
            string valoresultado = obj.DecirHola();
            //Afirmar
            Assert.AreEqual(valoresperado, valoresultado);
        }
        [TestMethod]
        public void TestSuma2Mas2Iguala4()
        {
            //Organizar
            SI220Z1.Aritmetica obj = new SI220Z1.Aritmetica();
            int valoresperado = 4;
            //Actuar
            int valoresultado = obj.sumar(2,2);
            //Afirmar
            Assert.AreEqual(valoresperado, valoresultado);
        }
        [TestMethod]
        public void TestSuma2MasNullIguala2()
        {
            //Organizar
            SI220Z1.Aritmetica obj = new SI220Z1.Aritmetica();
            int valoresperado = 2;
            //Actuar
            int valoresultado = obj.sumar(2, null);
            //Afirmar
            Assert.AreEqual(valoresperado, valoresultado);
        }
    }
}
