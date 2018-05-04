using System;
using System.Threading.Tasks;

namespace TaskAndTaskSchedulingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => DoSomeWork(), () => DoSomeOtherWork());
        }

        static void DoSomeWork(){
            Console.WriteLine("I'm doing something.");
        }

        static void DoSomeOtherWork(){
            Console.WriteLine("I'm waiting.");
        }
    }
}
