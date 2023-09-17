namespace MyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "none";
            int count = 0;

            Display display = new Display();
            
            while (message != "exit")
            {
                message = display.GetMessage();
                display.DisplayValue(message);
            }

            count = display.Count;
            if (count <= 2)
            {
                DisplayValue("You have less than 3 entries");
            }
            else
            {
                DisplayValue("Your number of entries are: ", count);

            }
        }

        private static void DisplayValue(string message)
        {
            Console.WriteLine(message);
        }

        private static void DisplayValue(String message, int count)
        {
            Console.WriteLine(message + count);
        }
    }
}