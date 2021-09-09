using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeProject.classes
{
    class GameClass
    {
        // Instantiate random number generator.  
        private readonly Random _random = new Random();
        private int ChanceGenerator(int min, int max) { return _random.Next(min, max); }

        public int AmountSuccess { get; set; }
        public int AmountFailed { get; set; }
        public int Chance => ChanceGenerator(1, 100);
    }
}
