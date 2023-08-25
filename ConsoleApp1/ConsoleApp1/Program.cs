namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Date = Console.ReadLine();
            try
            {
                DateTime vaxt = DateTime.ParseExact(Date, "dd | MM | yyyy", null);
                Console.WriteLine(vaxt.ToString("dd | MM | yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}