using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerProject
{
    class Program
    {

        static int nbCoup = 0;

        static void Main(string[] args)
        {
           
            Deplacer(4, 1, 2, 3);
           

            Console.WriteLine($"La tour a été constituée en {nbCoup} coups");
            Console.ReadLine();
        }


        public static void Deplacer(int diskCount, int fromPole, int toPole, int viaPole)
        {
            if (diskCount == 1)
            {
                Console.WriteLine("Move disk from pole " + fromPole + " to pole " + toPole);
                nbCoup++;
            }
            else
            {
                Deplacer(diskCount - 1, fromPole, viaPole, toPole);
                Deplacer(1, fromPole, toPole, viaPole);
                Deplacer(diskCount - 1, viaPole, toPole, fromPole);
            }
        }


    }
}
