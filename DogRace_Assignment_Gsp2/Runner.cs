using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace_Assignment_Gsp2
{
    public class Runner : PlayerResult
    {
        Random rd = new Random();
        public int jump() {
            return rd.Next(1, 50);
        }
    }
}
