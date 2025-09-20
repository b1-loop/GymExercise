using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymExercise
{
    public class Employee : User
    {
        public string Class;

        public void WhichWorkOut()
        {
            Console.WriteLine($"Denna trännare har {Class} pass");
        }
    }
}
