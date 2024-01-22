namespace numbers.txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowNumber = 1; 
            int highNumber = 10; 

           
            int[] numbers = Enumerable.Range(lowNumber, highNumber - lowNumber + 1).ToArray();

            
            Array.Sort(numbers);
            Array.Reverse(numbers);

           
            string filePath = "numbers.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (int number in numbers)
                    {
                        writer.WriteLine(number);
                    }
                }

                Console.WriteLine("Numbers written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
                

