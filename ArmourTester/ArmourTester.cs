using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class ArmourTester
    {
        [TestMethod]
        public void TestArmour1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int lvl = ar.getLevel();

            if(lvl != 2) { 
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestSlot1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int slot = ar.getSlot();

            if (slot != 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMaxProt1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 10, 2, 2);
            int maxProt = ar.getMaxProt();

            if (maxProt > 20 || maxProt <0)
            {
                Assert.Fail();
            } 
        }

        [TestMethod]
        public void TestCurCondition1()
        {
            Armour ar = new Armour("Jeps", "Jeppulis", 20, 2, 2);
            string curCond = ar.getCondition();

            if (curCond == null)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestSlotLevel()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 10, 4, 4);
            int slot = ar.getSlot();
            int level = ar.getLevel();

            Assert.AreEqual(slot,level);
        }
    }
}
