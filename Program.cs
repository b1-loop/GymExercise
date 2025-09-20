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



        }
    }
}
