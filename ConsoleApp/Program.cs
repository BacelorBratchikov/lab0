using Model;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person(string.Empty, "Ivanov", 20);
            }
            catch (ArgumentException exeption)
            {
                if (exeption.GetType() == typeof(ArgumentNullException)
                    || exeption.GetType() == typeof(ArgumentException))
                {
                    Console.WriteLine(exeption.Message);
                }
            }

            Person partner = new Person("Anastasia", "Kuznetsova", 19);
            /*
            person.Partner = partner;

            for (int i = 0; i < 20; i++)
            {
                person.CelebrateHappyBerthday();
            }

            Console.WriteLine(person.GetInfo());*/
            Console.ReadKey();
        }
    }
}