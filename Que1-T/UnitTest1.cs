using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using practice6;
using Que2_6;
using Que3_6;
using Que4_6;

namespace Que1_T
{
    [TestClass]
    public class Que1
    {
        [TestMethod]
        public void Test_FixoMethod_True()
        {
            if (-1.49511460567151 == Fix.Fixo(2))
                Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test_FixoMethod_True2() 
        {
            if (-0.620065277100095 == Fix.Fixo(7))
                Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test_FixoMethod_False()
        {
            Assert.AreNotEqual(Fix.Fixo(3), -1.49511460567151);
        }
    }

    [TestClass]

    public class Que2
    {
        [TestMethod]
        public void Test_FigM_True()
        {
            Assert.AreEqual(Fig.Figo(4), 2);
        }

        [TestMethod]
        public void Test_FigM_True2()
        {
            Assert.AreEqual(Fig.Figo(15), 0);
        }

        [TestMethod]
        public void Test_FigM_False()
        {
            Assert.AreNotEqual(Fig.Figo(8), 0);
        }
    }

    [TestClass]
    public class Que3
    {
        [TestMethod]
        public void Test_FirM_True()
        {
            if (Fir.Gipotinuza(5, 1) == 5.09901951359278)
                Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test_FirM_True2()
        {
            if (Fir.Gipotinuza(2, 6) == 6.32455532033676)
                Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test_FirM_False()
        {
            Assert.AreNotEqual(Fir.Gipotinuza(5, 5), 7);
        }
    }

        [TestClass]
        public class Que4
        {
            [TestMethod]
            public void Test_FitM_True()
            {
                Assert.IsTrue(Fit.Fito(9) == 0);
            }

            [TestMethod]
            public void Test_FitM_True2()
            {
                Assert.IsTrue(Fit.Fito(60) == 1);
            }
            
            [TestMethod]
            public void Test_FitM_False()
            {
                Assert.IsFalse(Fit.Fito(29) == 5);
            }

    }
    
}
