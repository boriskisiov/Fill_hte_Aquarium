namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Lenght = int.Parse(Console.ReadLine());
            int Widht = int.Parse(Console.ReadLine());
            int Hight = int.Parse(Console.ReadLine());
            double Percents = double.Parse(Console.ReadLine());

            double VolumeLiters = Lenght * Widht * Hight * 0.001;
            double WaterPercents = 1 - Percents / 100;
            double NededWater = VolumeLiters * WaterPercents;

            Console.WriteLine($"(NededWater:f2)");

            
        }
    }
}
