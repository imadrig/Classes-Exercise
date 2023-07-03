namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car car1 = new Car();
            car1.Make = "Honda";
            car1.Model = "Civic";
            car1.Year = 2014;

            car1.CarDetails();


        }
    }

}
