namespace GymExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tillkallar en instans av gym klassen och sätter värden på dess egenskaper
            Gym gym1 = new Gym();
            gym1.Name = "Nordic";
            gym1.Adress = "Gymvägen 1";
            gym1.Contact = 123456789;
            gym1.OpenHours = "06:00 - 22:00";
            gym1.ShowInfo();
           
        }
    }
}
