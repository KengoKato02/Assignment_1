using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandaAssig_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandaAssig_1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer footballplayer = new FootballPlayer(80890, "Adam", 90, 66);
        private FootballPlayer errorNamePlayer = new FootballPlayer(76890, "K", 80, 43);
        private FootballPlayer errorAgePlayer = new FootballPlayer(75830, "Bin", 0, 10);
        private FootballPlayer errorShirtNumberPlayer = new FootballPlayer(27345, "Xing", 99, 798);

        [TestMethod()]
        public void nameValidatorTest()
        {
            footballplayer.nameValidator();
            Assert.ThrowsException<ArgumentException>(() => errorNamePlayer.nameValidator());
        }

        [TestMethod()]
        public void ageValidatorTest()
        {
            footballplayer.ageValidator();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => errorAgePlayer.ageValidator());
        }

        [TestMethod()]
        public void shirtNumberValidatorTest()
        {
            footballplayer.shirtNumberValidator();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => errorShirtNumberPlayer.shirtNumberValidator());
        }
    }
}