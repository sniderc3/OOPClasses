namespace MyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "none";

            Display display = new Display();
            
            while (message != "exit")
            {
                message = display.GetMessage();
                display.DisplayValue(message);
            }            
        }
    }
}