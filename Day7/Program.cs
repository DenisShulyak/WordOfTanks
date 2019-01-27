using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            int PanteraPoints = 0;
            int T34Points = 0;
            Tank tank1 = new Tank("T-34");
            Tank tank2 = new Tank("T-34");
            Tank tank3 = new Tank("T-34");
            Tank tank4 = new Tank("T-34");
            Tank tank5 = new Tank("T-34");

            Tank tank6 = new Tank("Pantera");
            Tank tank7 = new Tank("Pantera");
            Tank tank8 = new Tank("Pantera");
            Tank tank9 = new Tank("Pantera");
            Tank tank10 = new Tank("Pantera");

  


            Console.WriteLine("1) Одержал победу танк : " + tank1 * tank6);
            if(tank1 * tank6 == "Pantera")
            {
                PanteraPoints++;
            }
            else if (tank1 * tank6 == "T-34")
            {
                T34Points++;
            }
            Console.WriteLine("2) Одержал победу танк : " + tank2 * tank7);
            if (tank2 * tank7 == "Pantera")
            {
                PanteraPoints++;
            }
            else if (tank2 * tank7 == "T-34")
            {
                T34Points++;
            }
            Console.WriteLine("3) Одержал победу танк : " + tank3 * tank8);
            if (tank3 * tank8 == "Pantera")
            {
                PanteraPoints++;
            }
            else if (tank3 * tank8 == "T-34")
            {
                T34Points++;
            }
            Console.WriteLine("4) Одержал победу танк : " + tank4 * tank9);
            if (tank4 * tank9 == "Pantera")
            {
                PanteraPoints++;
            }
            else if (tank4 * tank9 == "T-34")
            {
                T34Points++;
            }
            Console.WriteLine("5) Одержал победу танк : " + tank5 * tank10);
            if (tank5 * tank10 == "Pantera")
            {
                PanteraPoints++;
            }
            else if (tank5 * tank10 == "T-34")
            {
                T34Points++;
            }


            if(PanteraPoints > T34Points)
            {
                Console.WriteLine("Победила команда с танками Pantera!");
            }
            else if(PanteraPoints < T34Points)
            {
                Console.WriteLine("Победила команда с танками T-34!");

            }
            else
            {
                Console.WriteLine("Между командами ничья!");
            }

            Console.ReadLine();
        }
    }
}
