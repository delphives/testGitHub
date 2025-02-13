namespace TestGithubConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //ajout dans la branche 'ajout_writeline'
            Console.WriteLine("Hello, World! from ajout_writeline");
        }

        //ajout de cette méthode dans la brache 'main'
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
