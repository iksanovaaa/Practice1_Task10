using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            do
            {
                Console.WriteLine($@"«Считалка». Даны натуральные n, m. Предполагается, что n человек встают
в круг и получают номера, считая против часовой стрелки, 1, 2, ..., n. Затем, начиная с первого, 
также против часовой стрелки отсчитывается m-й человек (поскольку люди стоят по кругу, 
то за n-м человеком стоит первый). Этот человек выходит из круга, после чего, начиная со следующего, 
снова отсчитывается m - й человек и так до тех пор, пока из всего круга не остается один человек.Определить его номер. ");
                MyList list = new MyList();
                int n = CheckInt("Введите количество человек: ", true);
                list.Create(n);
                int m = CheckInt("Введите номер, до которого нужно отсчитывать:", false);
                PrintMes("Номер оставшегося человека: " + list.Delete(m));
                end = CheckKey();
            } while (!end);
        }
        //проверка ввода целого числа
        public static int CheckInt(string s, bool mans)
        {
            PrintMes(s);
            int number;
            int min = 0;
            if (mans) min = 1;
            bool okay = false;
            do
            {
                okay = Int32.TryParse(Console.ReadLine(), out number) && number > min;
                if (!okay) if (mans) PrintError("Некорретный формат входной строки. Введите целое число больше 1");
                    else PrintError("Некорретный формат входной строки. Повторите ввод целого положительного числа.");
            } while (!okay);
            return number;
        }
        //печать сообщения
        public static void PrintMes(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        //печать сообщения об ошибке
        public static void PrintError(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        
        //проверка на выход из программы
        public static bool CheckKey()
        {
            bool next, end = false;
            int keyNum;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Для выхода из программы нажмите Esc, для проверки другой считалки нажмите Enter.");
            do
            {
                keyNum = Console.ReadKey().KeyChar;
                next = (keyNum == 27) || (keyNum == 13);
            } while (!next);
            if (keyNum == 27) end = true;
            else Console.Clear();
            Console.ResetColor();
            return end;
        }

    }
}
