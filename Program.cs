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

            //tillkallar en instans av Employee klassen och sätter värden på dess egenskaper
            Employee employee1 = new Employee();
            employee1.Name = "Anna";
            employee1.Surname = "Andersson";
            employee1.Age = 30;
            employee1.Id = 1;
            employee1.Class = "Yoga";
            employee1.WhichWorkOut();

            //tillkallar ännu en instans av Employee klassen och sätter värden på dess egenskaper
            Employee employee2 = new Employee();
            employee2.Name = "Erik";
            employee2.Surname = "Eriksson";
            employee2.Age = 35;
            employee2.Id = 2;
            employee2.Class = "Spinning";
            employee2.WhichWorkOut();

            //tillkallar en tredje instans av Employee klassen och sätter värden på dess egenskaper 
            Employee employee3 = new Employee();
            employee3.Name = "Maria";
            employee3.Surname = "Karlsson";
            employee3.Age = 28;
            employee3.Id = 3;
            employee3.Class = "Zumba";
            employee3.WhichWorkOut();

            //tillkallar en instans av Customer klassen och sätter värden på dess egenskaper
            Customer customer1 = new Customer();
            customer1.Name = "Kalle";
            customer1.Surname = "Karlsson";
            customer1.Age = 25;
            customer1.Id = 1;
            customer1.HowToPay1();

            //tillkallar ännu en instans av Customer klassen och sätter värden på dess egenskaper
            Customer customer2 = new Customer();
            customer2.Name = "Lisa";
            customer2.Surname = "Lind";
            customer2.Age = 22;
            customer2.Id = 2;
            customer2.HowToPay2();

            //tillkallar flera instans av Workout klassen och sätter värden på dess egenskaper och anropar metoden WhichWorkout plus skriver ut information om passet
            //och även tillkallar från mina andra klasser för att se tränare och brukare som är anmälda till passet
            Workout workout1 = new Workout();
            workout1.WorkoutType = "Yoga";
            workout1.StartTime = 10;
            workout1.EndTime = 11;
            workout1.Employe = employee1.Name;
            workout1.CustomerId = customer1.Id;
            workout1.WhichWorkout();

            Workout workout2 = new Workout();
            workout2.WorkoutType = "Spinning";
            workout2.StartTime = 12;
            workout2.EndTime = 13;
            workout2.Employe = employee2.Name;
            workout2.CustomerId = customer2.Id;
            workout2.WhichWorkout();

            //Här har jag inte kopplat någon brukare till passet för att visa att det går att skapa pass utan brukare också
            Workout workout3 = new Workout();
            workout3.WorkoutType = "Zumba";
            workout3.StartTime = 14;
            workout3.EndTime = 15;
            workout3.Employe = employee3.Name;
            workout3.WhichWorkout();



        }
    }
}
