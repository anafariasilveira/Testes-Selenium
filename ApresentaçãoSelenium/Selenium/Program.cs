namespace Selenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var webautomation = new AutomationWeb();

            string value = webautomation.TestWeb();

            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
