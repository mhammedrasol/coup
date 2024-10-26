using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coup
{
    public class Vachal
    {
        public string brand;
    }
    public class motorvachal : Vachal
    {
        public string name;
    }
          
    internal class Program
    {
        static void Main(string[] args)
            {
                motorvachal car = new motorvachal();
                car.name = "marseds";
                car.brand = "c600";
                motorvachal track = new motorvachal();
                track.name = "volvo";
                track.brand = "c100";
                Console.WriteLine(car.name);
                Console.WriteLine(car.brand);
                Console.WriteLine(track.name);
                Console.WriteLine(track.brand);
                Console.ReadLine();

            }
        }
}
