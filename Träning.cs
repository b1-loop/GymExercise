using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymExercise
{
    //denna klassen representerar en träning och dess egenskaper här vill jag lägga till olika träningspass som gymmet erbjuder vilka tränade 
    //man har, vilka tider det börjar och slutar samt ett sätt att anropa vilka brukare är där genom deras Id
    public class Workout 
    {
        public int StartTime;
        public int EndTime;
        public string Employe;
        public string WorkoutType;
        public int CustomerId;
        public void WhichWorkout()
        {
            Console.WriteLine($"Träningspass {WorkoutType} börjar kl {StartTime} och slutar kl {EndTime}, det är {Employe} som håller i passet och brukare med Id {CustomerId} är anmäld till detta pass");
        }
    }
}
