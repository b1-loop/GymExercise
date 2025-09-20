using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GymExercise
{
    public class Customer : User
    {
      public void HowToPay1()
        {
            Console.WriteLine("Denna kund vill betala månadsvist");
        }

        public void HowToPay2()
            {
                Console.WriteLine("Denna kund vill betala årsvist");
        }
    }
}
