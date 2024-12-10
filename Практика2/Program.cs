using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Практика2
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Введите строку с нулем.");

            string stringFromTask1 = Convert.ToString(Console.ReadLine());
            int zeroinTask1 = 1;
            int count = 0;
            foreach (char c in stringFromTask1)
            {

                if (c == '0')
                {
                    count++;
                    break;
                }
                zeroinTask1++;
            }
            if (count != 1)
            {
                Console.WriteLine("Здесь нет  нуля! Переделывай");
                Task1();
            }
            else
            {


                Console.WriteLine("Позиция первого нуля: " +
                    zeroinTask1);
            }
        }


        static void Task2()
        {
            int quantity = 0;
            for (int i = 1; i <= 1000; i++)
            {
                int firstDigit = (i / 100) % 10;
                int secondDigit = (i / 10) % 10;
                if (firstDigit + secondDigit == 5)
                {
                    quantity++;
                }
            }
            Console.WriteLine(quantity);
        }

        static void Task3()
        {
            int[] array = [18, 30, 45, 64, 56, 90];
            array = array.Where(val => val != 45).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        static void Task4()
        {
            int[] array = [1, 2, 3, 4, 5, 6];
            int half = array.Length / 2;
            int sum = 0;
            for (int i = 0; i < half; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        static void Task5()
        {
            int[] array = [1, 2, -3, 4, -5, 6, -90, 23, -87, -890];
            int elementsQuantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    elementsQuantity++;
                }
            }
            Console.WriteLine(elementsQuantity);
        }

        static void Task6()
        {
            int[] array = [1, 2, -3, 4, -5, 6, -90, 23, -87, -890];
            array = array.Where(val => val >0 ).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void Task7()
        {
            string str = "PLC";

            for (int i = 0; i < str.Length; i++)
            {
                if (i != str.Length - 2)
                {
                    Console.Write(str[i]);

                }
            }
            Console.WriteLine();
        }

        static void Task8()
        {
            int[] array = [1, 2, 3, 4, 5, 6];
            int half = array.Length / 2;
            int sumOfFirstHalf = 0;
            int sumOfSecondHalf = 0;    
            for (int i = 0; i < half; i++)
            {
                sumOfFirstHalf += array[i];
            }
            for (int i = half; i < array.Length; i++)
            {
                sumOfSecondHalf += array[i];
            }
            
            var result = (float)sumOfFirstHalf / sumOfSecondHalf;
            
            Console.WriteLine(result);
        }

        static void Task9()
        {
            string word = "decapitation";
            string word2 = "negotiations";
            char letter1 = word[word.Length - 1];
            char letter2 = word2[0];
            if (letter1 == letter2)
            { 
                Console.WriteLine("Все верно");
            }

        }

        static void Task10()
        {
            Console.WriteLine("Введите строку с нулем.");

            string stringFromTask1 = Convert.ToString(Console.ReadLine());
            int zeroinTask10 = 1;
            int count = 0;
            foreach (char c in stringFromTask1)
            {

                if (c == '0')
                {
                    count++;
                    if (count == 3)
                    {
                        break;
                    }
                }
                zeroinTask10++;
            }
            if (count != 3)
            {
                Console.WriteLine("Здесь нет третьего нуля! Переделывай");
                Task10();
            }
            else
            {
                Console.WriteLine("Позиция третьего нуля: " +
                    zeroinTask10);
            }
        }

        static void Task11()
        {
            string[] array = { "'", "1", "2", ",","3", "4",",", "5", "6" , "'"};
            array = array.Where(val => val != ","&& val!="'").ToArray();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Convert.ToInt32(array[i]);
            }
            Console.WriteLine(sum);

        }

        static void Task12()
        {
            string date = "2025-12-31";
            string year = "";
            string month = "";
            string day = "";
            
                for (int j = 0; j < 4; j++)
                {
                    year += date[j];
                }
                for (int j =5;j < 7; j++)
                {
                    month += date[j];
                }
                for (int j =8;j < 10; j++)
                {
                    day += date[j];
                }
            Console.WriteLine("{\n" +
                "Year: " + year+"\n"+
                "Month: "+ month+"\n"+
                "Day: "+day+"\n");

        }

        static void Task13()
        {
            int count = 0;
            string a = "asdqwe4tri4";
            foreach (char i in a)
            {
                count++;
                bool q = Char.IsNumber(i);
                if (q  == true)
                {
                    break;
                }
            }
            Console.WriteLine("Позиция первой цифры: " + count);
        }

        static void Task14()
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>() {
      {"name", "John"},
      {"age", "30"},
      {"city", "New York"}
    };
            string[] keys = new string[myDict.Count];
            string[] values = new string[myDict.Count];
            int i = 0;
            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                keys[i] = kvp.Key;
                values[i] = kvp.Value;
                i++;
            }
            Console.WriteLine("Keys:");
            foreach (string key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("\nValues:");
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }

        static void Task15()
        {
            int x = 123457688;
            string num = x.ToString();
            int evenNumberedQuantity = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int j = Convert.ToInt32(num[i]);
                if (j%2 == 0)
                {
                    evenNumberedQuantity++;
                }
            }
            Console.WriteLine("Количество четных цифр в числе: " + evenNumberedQuantity);
        }

        static void Task16()
        {
            string s = "abcde";
            int q = 0;
            foreach(char i in s)
            {
                if (q%2!=0)
                {
                    Console.Write(i);
                }
                if (q%2==0)
                {
                    char o = Char.ToUpper(i);
                    Console.Write(o);
                }
                q++;
            }
            Console.WriteLine();
        }

        static void Task17()
        {
            string a = "aaa bbb ccc";
            bool pass = false;
            bool upper = false;
            for (int i = 0;i < a.Length;i++)
            {
                if (upper==true)
                {
                    char o = Char.ToUpper(a[i]);
                    Console.Write(o);
                    pass = true;
                    upper = false;
                }
                if(i==0)
                {
                    char o = Char.ToUpper(a[i]);
                    Console.Write(o);
                    pass = true;
                }
                if (a[i] == ' ')
                {
                    Console.Write(a[i]);
                    upper = true;
                }
                if (pass == false)
                {
                    Console.Write(a[i]);
                }
                pass = false;
            }
            Console.WriteLine();
        }

        static void Task18()
        {
            string s = "023m0df0dfg0";
            int[] pos = {};
            int qq = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] =='0')
                {
                    Array.Resize(ref pos, qq+1);
                    pos[qq] = i;
                    qq++;
                }
            }


            
            Console.WriteLine("Позиции всех нулей: ");
            
            for (int i = 0;i<pos.Length;i++)
            { 
                Console.Write(pos[i]+ " "); 
            }
        }

        static void Task19()
        {
            string s = "abcdefg";
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if ((i+1) % 3 != 0)
                {
                    
                    res += s[i];
                }
                
            }
            Console.WriteLine(res) ;
        }

        static void Task20()
        {
            int[] array = [1, 2, 3, 4, 5, 6];
            int sumOfFirstHalf = 0;
            int sumOfSecondHalf = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumOfFirstHalf += array[i];
                }
                if (array[i] % 2 != 0)
                {
                    sumOfSecondHalf += array[i];
                }
            }
            

            var result = (float)sumOfFirstHalf / sumOfSecondHalf;

            Console.WriteLine(result);
        }

        static void Task21()
        {
            Console.WriteLine("Введите символ:");
            char a  =Convert.ToChar(Console.ReadLine());
            bool v = Char.IsUpper(a);
            if (v==true)
            {
                Console.WriteLine("Верхний регистр"); 
            }
            else
            {
                Console.WriteLine("Нижний регистр");
            }
        }

        static void Task22()
        {
            Console.WriteLine("Введите строку(только не более 2 заглавных букв)");
            string s = Console.ReadLine();
            bool isupper = false;
            int count = 0;
            for (int i = 0; i<s.Length; i++)
            {
                isupper = Char.IsUpper(s[i]);
                if (isupper == true)
                {
                    count++;
                    isupper = false;
                }
                if (count > 2)
                {
                    Console.WriteLine("А я предупреждал! Теперь вводи заново!");
                    Task22();
                }
            }
            Console.WriteLine("Ваша строка: " + s);

        }
        static void Task23()
        {
            Console.WriteLine("Введите строку(только не более 3 букв)");
            string s = Console.ReadLine();
            bool isletter = false;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                isletter = Char.IsLetter(s[i]);
                if (isletter == true)
                {
                    count++;
                    isletter = false;
                }
                if (count > 3)
                {
                    Console.WriteLine("А я предупреждал! Теперь вводи заново!");
                    Task23();
                }
            }
            Console.WriteLine("Ваша строка: " + s);
        }

        static void Task24()
        {
            int x = 26789073;
            string s = Convert.ToString(x);
            for(int i =s.Length-1; i>0; i--)
            {
               
                if(int.Parse(s[i].ToString()) % 2 == 0)
                {
                    Console.WriteLine("Первая четная цифра с конца: " + int.Parse(s[i].ToString()));
                    break;
                }
                
            }
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Menu:\n" +
                    "Выберите задачу, решение которой хотите посмотреть:");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            Task1();
                            break;
                        }
                    case 2:
                        {
                            Task2();
                            break;
                        }
                    case 3:
                        {
                            Task3();
                            break;
                        }
                    case 4:
                        {
                            Task4();
                            break;
                        }
                    case 5:
                        {
                            Task5();
                            break;
                        }
                    case 6:
                        {
                            Task6();
                            break;
                        }
                    case 7:
                        {
                            Task7();
                            break;
                        }
                    case 8:
                        {
                            Task8();
                            break;
                        }
                    case 9:
                        {
                            Task9();
                            break;
                        }
                    case 10:
                        {
                            Task10();
                            break;
                        }
                    case 11:
                        {   
                            Task11();
                            break;
                        }
                    case 12:
                        {
                            Task12();
                            break;
                        }
                    case 13:
                        {
                            Task13();
                            break;
                        }
                    case 14:
                        {
                            Task14();
                            break;
                        }
                    case 15:
                        {
                            Task15();
                            break;
                        }
                    case 16:
                        {
                            Task16();
                            break;
                        }
                    case 17:
                        {
                            Task17();
                            break;
                        }
                    case 18:
                        {
                            Task18();
                            break;
                        }
                    case 19:
                        {
                            Task19();
                            break;
                        }
                    case 20:
                        {
                            Task20();
                            break;
                        }
                    case 21:
                        {
                            Task21();
                            break;
                        }
                    case 22:
                        {
                            Task22();
                            break;
                        }
                    case 23:
                        {
                            Task23();
                            break;
                        }
                    case 24:
                        {
                            Task24();
                            break;
                        }
            }

                Console.ReadKey();

            }
    }
}
