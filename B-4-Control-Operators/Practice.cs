using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            var nowtime = DateTime.Now.TimeOfDay;
            var morningtime = new TimeSpan(4, 0, 0);
            var daytime = new TimeSpan(12, 0, 0);
            var eveningtime = new TimeSpan(17, 0, 0);
            var nighttime = new TimeSpan(24, 0, 0);

            if (nowtime >= morningtime && nowtime < daytime)
                Console.WriteLine("Доброе утро, Ольга");

            else if (nowtime >= daytime && nowtime < eveningtime)
                Console.WriteLine("Добрый день, Ольга");

            else if (nowtime >= eveningtime && nowtime < nighttime) 
                Console.WriteLine("Добрый вечер, Ольга");

            else if (nowtime >= nighttime && nowtime < morningtime)
                Console.WriteLine("Доброй ночи, Ольга");


        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            Console.WriteLine("Введите x:");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int Y = int.Parse(Console.ReadLine());

            if (X == Y)
            {
                Console.WriteLine("Значения равны");
            }

            else if (X > Y)
            {
                Console.WriteLine("Значение X больше Y");
            }

            else
            {
                Console.WriteLine("Значение X меньше Y");
            }
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            Console.WriteLine("Введите x:");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int Y = int.Parse(Console.ReadLine());

            if (X >= 0 && Y >= 0)
            {
                if (X == Y)
                {
                    Console.WriteLine("Значения равны");
                }

                else if (X > Y)
                {
                    Console.WriteLine("Значение X больше Y");
                }

                else
                {
                    Console.WriteLine("Значение X меньше Y");
                }
            }

            else if (X < 0)
            {
                Console.WriteLine("X  меньше 0");
            }

            else
            {
                Console.WriteLine("Y  меньше 0");
            }



        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            Console.WriteLine("Введите любое число от 1 до 5");
            var number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Вы ввели 1");
            }

            else if (number == 2)
            {
                Console.WriteLine("Вы ввели 2");
            }

            else if (number == 3)
            {
                Console.WriteLine("Вы ввели 3");
            }
            else if (number == 4)
            {
                Console.WriteLine("Вы ввели 4");
            }

            else if (number == 5)
            {
                Console.WriteLine("Вы ввели 5");
            }

            else
            {
                Console.WriteLine("Неверное число");
            }

        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var today = DateTime.Today;
            var dayOfWeek = (int)today.DayOfWeek;
            switch (dayOfWeek - 1) {
                case 0:
                    Console.WriteLine("Доброго понедельника, Ольга");
                    break;
                case 1:
                    Console.WriteLine("Доброго вторника, Ольга");
                    break;
                case 2:
                    Console.WriteLine("Доброй среды, Ольга");
                    break;
                case 3:
                    Console.WriteLine("Доброго четверга, Ольга");
                    break;
                case 4:
                    Console.WriteLine("Доброй пятницы, Ольга");
                    break;
                case 5:
                    Console.WriteLine("Доброй субботы, Ольга");
                    break;
                case 6:
                    Console.WriteLine("Доброго воскресенья, Ольга");
                    break;
            }
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            Console.WriteLine("Введите символ");
            char character = Convert.ToChar(Console.ReadLine());

            switch (character)
            {
                case 'W':
                case 'w':
                    Console.WriteLine("Фигура перемещена вверх");
                    break;

                case 'S':
                case 's':
                    Console.WriteLine("Фигура перемещена вниз");
                    break;

                case 'A':
                case 'a':
                    Console.WriteLine("Фигура перемещена влево");
                    break;

                case 'D':
                case 'd':
                    Console.WriteLine("Фигура перемещена вправо");
                    break;

                default:
                    Console.WriteLine("Фигура не перемещена");
                    break;


            }


        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($" Число {i} четное");
                }

                else
                {
                    Console.WriteLine($" Число {i} нечетное");
                }
            }

        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for (int i = 30; i >= 0; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }

        }
        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
            int row = 10;
            int column = 10;
            int[,] A = new int[row, column];
            Random ran = new Random();

            for ( int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    A[i, j] = ran.Next(1, 9);

                    Console.Write(A [i, j] + " ");
                }

                Console.WriteLine(" ");
            } 
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for (int i = 0; i < 6; i++)
                Console.WriteLine("Hello World!");
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            for (int i = 10; i >= 0; i--)
                Console.WriteLine(i);

        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            for (int i = 0; i >= -10; i--)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} четное");
                else
                    Console.WriteLine("{i} нечетное");
            }
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            Console.WriteLine("Ввите слово: ");
            string word = Console.ReadLine();

            int sumA = 0;
            foreach (int i in word)
            {
                if (i == 'a')
                    sumA += 1;
            }

            Console.WriteLine(sumA);
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            char alph;
            int n = 0;
            char[] alphabet = new char[26];

            for (int i = 122; i >= 97; i--)
            {
                alph = Convert.ToChar(i);
                alphabet[n] = alph;
                n++;
                Console.WriteLine(alph);
            }

        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            Console.WriteLine("Введите n: ");
            int number = 1;
            int n = int.Parse(Console.ReadLine());


            while (number <= n)
            {
                if (number % 2 == 0)
                    Console.WriteLine(number);
                number++;
            }
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
            Console.WriteLine("Введите n: ");
            int number = 1;
            int n = int.Parse(Console.ReadLine());


            while (number <= n)
            {
                if (number % 2 != 0)
                    Console.WriteLine(number);
                number++;
            }
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            int steps = 6;
            while (steps > 0)
            {
                Console.WriteLine("Hello world!");
                steps--;
            }
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            Console.WriteLine("Введите число");

            int number = int.Parse(Console.ReadLine());
            int result = 1;

            Console.WriteLine("Введите степень");
            int power = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= power)
            {
                result *= number;
                counter++;

            }
            Console.WriteLine(result);


        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {

            int result = 0;
            int sum = 4;
            while (result != sum) 
            {
                Console.WriteLine("Введите сумму 2+2");
                result = int.Parse(Console.ReadLine());
                
                if (result != sum)
                Console.WriteLine("Неверный ответ!");
            }
                  
            Console.WriteLine("Ответ верный");
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            int step = 1;

            while (step <= 25)
            {
                Console.WriteLine("Введите число от 1 до 6");
                int number = int.Parse(Console.ReadLine());

                step += number;   
            }

            Console.WriteLine("Конец игры");
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            int stepFirst = 1;
            int stepSecond = 1;

            while (stepFirst <= 25 || stepSecond <= 25)
            {
                Console.WriteLine("Первый игрок Введите число от 1 до 6");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Второй игрок Введите число от 1 до 6");
                int number2 = int.Parse(Console.ReadLine());

                stepFirst += number1;

                stepSecond += number2;
            }

            Console.WriteLine("Конец игры");
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            int number = 1;

            while (number>= 1 && number <= 100)
            {                
                Console.WriteLine("Введите число от 1 до 100");
                number = int.Parse(Console.ReadLine());

                if(number >= 1 && number <= 100)
                    Console.WriteLine($"Ваше число {number}");

                else
                    Console.WriteLine("Неверное число");
            }
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            Console.WriteLine("Введите Х: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знак: ");
            char sign = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите Y: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            double dif = number1 - number2;
            double pro = number1 * number2;
            double quo = number1 / number2;

            if (sign == '+')
                Console.WriteLine($"= {sum}");

            else if (sign == '-')
                Console.WriteLine($"= {dif}");

            else if (sign == '*')
                Console.WriteLine($"= {pro}");

            else if (sign == '/')
                Console.WriteLine($"= {quo}");

            Console.ReadKey();
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            Console.WriteLine("Введите Х: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знак: ");
            char sign = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите Y: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            double dif = number1 - number2;
            double pro = number1 * number2;
            double quo = number1 / number2;

            switch (sign)
            {
                case '+':
                    Console.WriteLine($"= {sum}");
                    break;

                case '-':
                    Console.WriteLine($"= {dif}");
                    break;

                case '*':
                    Console.WriteLine($"= {pro}");
                    break;

                case '/':
                    Console.WriteLine($"= {quo}");
                    break;
            }
        }
        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            string reverse = null;
            
            foreach (var i in word)
            {
                reverse = i + reverse;
            }
            Console.WriteLine(reverse);
        }

        //B4-P25/25 Cycle_WordRevercseMY- через библиотеку
        public static void B4_P25_25_Cycle_WordRevercseMY()
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();

            Console.WriteLine(string.Concat(word.Reverse()));
        }
    }
}
