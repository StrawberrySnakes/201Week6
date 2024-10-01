namespace week6demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Dessa";

            void PrintMyName(string name) {
                Console.WriteLine("Hello "+name);
            }

            int GiveMeSix() { 
                return 6; 
            }

            PrintMyName(name);
            Console.WriteLine(GiveMeSix());
        }
    }
}
