using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandaAssig_1
{
    public class FootballPlayer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int shirtNumber { get; set; }
        public FootballPlayer(int iD, string name, int age, int shirtNumber)
        {
            ID = iD;
            Name = name;
            Age = age;
            this.shirtNumber = shirtNumber;
        }
        public void nameValidator()
        {
            if (Name.Length < 2)
            {
                throw new ArgumentException();
            }
        }
        public void ageValidator()
        {
            if (Age < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void shirtNumberValidator()
        {
            if ((shirtNumber <= 1) || (shirtNumber >= 99))
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}