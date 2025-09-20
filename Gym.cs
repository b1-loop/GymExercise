

namespace GymExercise
{
    public class Gym //denna klassen representerar ett gym och dess egenskaper
    {
        public string Name;
        public string Adress;
        public int Contact;
        public string OpenHours;

        public void ShowInfo()
        {
            Console.WriteLine($"Vällkommen till {Name} ni hittar oss på {Adress},vi har öppet varje dag mellan {OpenHours} vid frågor ring till {Contact}");
        }


    }
}
