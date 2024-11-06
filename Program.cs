namespace CCAD16_Assignment1_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //show length of an array
            //sort an array
            //Print unsorted and then sorted arrays

            string[] motorcycles = {"Harley", "Aprilia", "Suzuki", "Indian"};
            string[] holidays = {"Christmas", "Thanksgiving", "Halloween" };

            //printing length of arrays
            Console.WriteLine(motorcycles.Length);
            Console.WriteLine(holidays.Length);
            Console.WriteLine("");

            //unsorted motorcycle array
            foreach (string motorcycle in motorcycles)
            {
                Console.WriteLine(motorcycle);
            }
          
            Console.WriteLine("");
          
            //sorted holiday array
            foreach (string holiday in holidays)
            {
                Array.Sort(holidays);
                Console.WriteLine(holiday);
            }
        }
    }
}
