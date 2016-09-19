using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1Labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil manon = new Pupil("Manon",12, 1);
            Activity piscine = new Activity("piscine", true);
            Activity yoga = new Activity("Yoga", true);
            Activity judo = new Activity("Judo", false);

            manon.AddActivity(piscine);
            manon.AddActivity(yoga);
            manon.AddActivity(judo);

            System.Console.Write(manon);
            System.Console.Read();

        }
    }
}
