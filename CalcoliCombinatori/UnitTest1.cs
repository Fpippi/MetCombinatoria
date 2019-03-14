using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//Faccio il test del 5
        {
            int n1 = 5, risultato = 120;

            int risultato2 = EquazioniLibrary.CalcoliCombinatori.fattoriale(n1);
            Assert.AreEqual(risultato, risultato2);
        }

        [DataTestMethod]
        [DataRow(0,1)]
        [DataRow(1,1)]
        public void TestMethod3(int n1,int risultato)//Faccio il test dello 0 //Faccio il test del 1
        {
            int risultato2 = EquazioniLibrary.CalcoliCombinatori.fattoriale(n1);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestMethod4()//Faccio il test del 13
        {
            int n1 = 12, risultato = 479001600;
            //il massimo con in è 2 147 483 647 quindi se provo a fare il fattoriale di 13 mi va in overflow quindi non riesco a rappresentarlo
            int risultato2 = EquazioniLibrary.CalcoliCombinatori.fattoriale(n1);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestMethod5()//Faccio il test del 10
        {
            int n1 = 10, risultato = 3628800;
            //il massimo con in è 2 147 483 647 quindi se provo a fare il fattoriale di 13 mi va in overflow quindi non riesco a rappresentarlo
            int risultato2 = EquazioniLibrary.CalcoliCombinatori.fattoriale(n1);
            Assert.AreEqual(risultato, risultato2);
        }
    }
}
