using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonOne = Singleton.GetInstance();
            Singleton singletonTwo = Singleton.GetInstance();

            if (singletonOne == singletonTwo)
            {
                Console.WriteLine("It work");
            }
            else
            {
                Console.WriteLine("Dont work");
            }
        }
    }
}
