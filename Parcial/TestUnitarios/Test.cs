using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestUnitarios
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test_InventarioGuardar()
        {
            bool retorno = Inventario.Guardar();

            Assert.IsTrue(retorno);
        }
    }
}
