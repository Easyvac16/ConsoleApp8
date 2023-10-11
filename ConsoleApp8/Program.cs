using System.Diagnostics;

namespace ConsoleApp8
{
    internal class Program
    {
        private static string name = "C:\\Users\\gdima\\source\\repos\\ConsoleApp6\\ConsoleApp6\\bin\\Debug\\net6.0\\ConsoleApp6.exe";
        static void Main(string[] args)
        {   
            Process process = new Process();

            Console.WriteLine("------1------");

            process.StartInfo.FileName = "calc.exe";
            process.Start();
            process.WaitForExit();
            Console.WriteLine("Exit code " + process.ExitCode);

            Console.WriteLine("------2------");

            Console.WriteLine("Write 1 number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write 2 number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write operation number:");
            string operation = Console.ReadLine();

            
            process.StartInfo.FileName = name;
            process.StartInfo.Arguments = $"{num1} {num2} {operation}";
            process.Start();

            
            process.StartInfo.FileName = "C:\\Program Files\\VideoLAN\\VLC\\vlc.exe";

            Console.WriteLine("------3------");

            Console.WriteLine("Choose 1:Start process and wait for exit or 2:ShutDown process");
            int a = int.Parse(Console.ReadLine());
            if (a == 1 || a == 2) { 
                switch (a)
                {
                    case 1:
                        process.Start();
                        process.WaitForExit();
                        Console.WriteLine("Exit code " + process.ExitCode);
                        break;
                    case 2:
                        process.Start();
                        process.Kill();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("------4------");

            Console.WriteLine("Write file path:");
            string Path = Console.ReadLine();
            Console.WriteLine("Write search word:");
            string Word = Console.ReadLine();

            process.StartInfo.FileName = "C:\\Users\\gdima\\source\\repos\\ConsoleApp9\\ConsoleApp9\\bin\\Debug\\net6.0\\ConsoleApp9.exe";
            process.StartInfo.Arguments = $"{Path} {Word}";
            process.Start();

        }
    }
}