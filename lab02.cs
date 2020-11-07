using System;
using System.Globalization;

namespace hod_konem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбери фигуру: 1. Конь 2. Ладья 3. Слон");
            int figchoose;
            do
            {
                figchoose = int.Parse(Console.ReadLine());
                if(figchoose > 3 || figchoose < 1)
                    Console.WriteLine("Вы долбаёб!");
            }
            while (figchoose > 3 || figchoose < 1);
            Console.WriteLine("Введите начальную координату:");
            int gorkoor = 0;
            int verkoor = 0;
            proverkanaeblana(ref gorkoor, ref verkoor);

            Console.WriteLine("Введите конченую координату:");
            int gorkoor2 = 0;
            int verkoor2 = 0;
            proverkanaeblana(ref gorkoor2, ref verkoor2);
            string kkord = Console.ReadLine();

            if (figchoose == 1)
            {
                xodkonya(gorkoor, verkoor, gorkoor2, verkoor2);
            }
            else if (figchoose == 2)
            {
                hodladi(gorkoor, verkoor, gorkoor2, verkoor2);
            }
            else if (figchoose == 3)
            {
                hodslona(gorkoor, verkoor, gorkoor2, verkoor2);
            }

        }
        static void xodkonya(int gorkoor, int verkoor, int gorkoor2, int verkoor2)
        {
            int raznicagor = Math.Abs(gorkoor2-gorkoor);
            int raznicaver = Math.Abs(verkoor2 - verkoor);
            if (raznicagor == 2 && raznicaver == 1)
                Console.WriteLine(true);
            else if (raznicagor == 1 && raznicaver == 2)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
        static void proverkanaeblana(ref int x, ref int y)
        {
            string koor;
            char provgor;
            int provver;
           
            do
            {
                koor = Console.ReadLine();
                provgor = koor[0];
                provver = Convert.ToInt32(Convert.ToString(koor[1]));
                if (provgor > 'H' || provgor < 'A' || provver < 1 || provver > 9)
                {
                    Console.WriteLine("Введена неверная координата.\nПопробуйте ещё раз.");
                }
                if (koor.Length<1 || koor.Length>2)
                {
                    Console.WriteLine("Таких координат не существует!");
                }
            }
            while (provgor > 'H' || provgor < 'A' || provver < 1 || provver > 9 || koor.Length < 1 || koor.Length > 2);


            x = provgor;
            y = provver;
        }
        static void hodladi(int gorkoor, int verkoor, int gorkoor2, int verkoor2)
        {
            int raznicagor = Math.Abs(gorkoor2 - gorkoor);
            int raznicaver = Math.Abs(verkoor2 - verkoor);
            if (raznicagor == 0 && raznicaver <= 8 && raznicaver > 0)
                Console.WriteLine(true);
            else if (raznicagor <=8 && raznicagor > 0 && raznicaver == 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

        }
        static void hodslona(int gorkoor, int verkoor, int gorkoor2, int verkoor2)
        {
            int raznicagor = Math.Abs(gorkoor2 - gorkoor);
            int raznicaver = Math.Abs(verkoor2 - verkoor);
            if (raznicagor<=8 && raznicagor >= 1 && raznicagor == raznicaver)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

        }
    }
}

