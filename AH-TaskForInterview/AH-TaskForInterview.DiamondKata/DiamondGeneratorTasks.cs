using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH_TaskForInterview.DiamondKata
{
    internal class DiamondGeneratorTasks
    {
        [Test]
        public void B_should_give_character_sequence()
        {
            DiamondGenerator tasks = new DiamondGenerator();
            string result= tasks.GenerateHalfDiamond(1);
            Assert.AreEqual("AB", result);
        }
    }
}
