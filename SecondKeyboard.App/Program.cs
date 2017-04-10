using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Owin.Hosting;

namespace SecondKeyboard.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://*:9000/";

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Started!");
                Console.ReadKey();
            }

            Console.WriteLine("Stopped!");
        }
    }
}
