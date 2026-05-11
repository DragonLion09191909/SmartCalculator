namespace SmartCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsNeeded = true;
            SCalc calc= new SCalc();


            while (true)
            {


                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;

                try
                {
                    double result = Parser.Instance.Parse(input);
                    Console.WriteLine($"Ответ: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }




            }
           
        }

       
    }
}
