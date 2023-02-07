namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("enter amount of tires for vehicle wanted:");


                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (input == false);

            var vehicle = vehiclefactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
