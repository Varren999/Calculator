using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Class1
    {
        static string Result(string one, string sign, string two)
        {
            try
            {
                switch (sign)
                {
                    case "+":
                        {
                            return Convert.ToString(Convert.ToDouble(one) + Convert.ToDouble(two));
                        }
                    case "-":
                        {
                            return Convert.ToString(Convert.ToDouble(one) - Convert.ToDouble(two));
                        }
                    case "*":
                        {
                            return Convert.ToString(Convert.ToDouble(one) * Convert.ToDouble(two));
                        }
                    case "/":
                        {
                            if (two == "0")
                                throw new DivideByZeroException();
                            else
                                return Convert.ToString(Convert.ToDouble(one) / Convert.ToDouble(two));
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("error Result");
                Console.ReadKey();
            }
            return "-1";
        }

        // Метод подменяет подстроку с пробелами если пользователь ввел текст без пробелов.
        static string ReplaceString(string text)
        {
            string[] old_simbol = { "+", "-", "*", "/", " +", "+ ", " -", "- ", " *", "* ", " /", "/ " };
            string[] new_simbol = { " + ", " - ", " * ", " / ", " + ", " + ", " - ", " - ", " * ", " * ", " / ", " / " };
            for (int i = 0; i < old_simbol.Length; i++)
            {
                text = text.Replace(old_simbol[i], new_simbol[i]);
            }
            return text;
        }

        // Метод убирает пустые строки из массива.
        static string[] EmptyString(string[] Arr)
        {
            string[] temp = Arr;
            Array.Resize(ref Arr, 3);
            for (int i = 0, j = 0; i < temp.Length; i++)
            {
                if (temp[i] != "" && temp[i] != " ")
                {
                    Arr[j] = temp[i];
                    j++;
                }
            }
            return Arr;
        }

        static List<string> Calculate(List<string> Current, string one, string two)
        {
            bool cycle = true;
            try
            {
                while (cycle)
                {
                    cycle = false;
                    if (Current.Count > 2)
                    {
                        for (int i = 1; i < Current.Count - 1; i++)
                        {
                            if (Current[i] == one && i != 0 || Current[i] == two && i != 0)
                            {
                                Current[i] = Result(Current[i - 1], Current[i], Current[i + 1]);
                                Current.RemoveAt(i + 1);
                                Current.RemoveAt(i - 1);
                                cycle = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("error Cycle");
                Console.ReadKey();
            }
            return Current;
        }

        static string Resultat(List<string> textList)
        {
            textList = Calculate(textList, "*", "/");
            textList = Calculate(textList, "+", "-");
            return textList[0];
        }

        static void Foo()
        {
            string text = "";
            Console.Write("Введите выражение: ");
            text = Console.ReadLine();

            List<string> strings = new List<string>(text.Split(' '));
            foreach (string s in strings)
            {
                Console.Write($"{s} ");
            }

            Console.Write(" = ");

            Console.WriteLine(Resultat(strings));
        }
    }
}