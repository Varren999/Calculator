using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Calculator
{
    internal class Result
    {
        public string outStr;

        public Result(string inStr)
        {
            inStr = ReplaceString(inStr);

            if (inStr.Length > 2) 
                outStr = Resultat(new List<string>(inStr.Split(' ')));
            else
            {             
                string[] temp = inStr.Split(' ');
                outStr = Count(temp[0], temp[1], temp[0]);
            }
        }

        // Метод подменяет подстроку с пробелами если пользователь ввел текст без пробелов.
        private string ReplaceString(string text) => text.Replace("+", " + ").Replace("-", " - ").Replace("*", " * ").Replace("/", " / ");

        // Метод убирает пустые строки из массива.
        private string[] EmptyString(string[] Array)
        {
            return Array.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
        }

        //
        private static List<string> Calculate(List<string> Current, string one, string two)
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
                                Current[i] = Count(Current[i - 1], Current[i], Current[i + 1]);
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
                MessageBox.Show($"error Calculate {ex.Message}");
            }
            return Current;
        }

        //
        private static string Count(string one, string sign, string two)
        {
            try
            {
                switch (sign)
                {
                    case "+": return Convert.ToString(Convert.ToDouble(one) + Convert.ToDouble(two));
                    case "-": return Convert.ToString(Convert.ToDouble(one) - Convert.ToDouble(two));
                    case "*": return Convert.ToString(Convert.ToDouble(one) * Convert.ToDouble(two));
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
                MessageBox.Show($"error Count {ex.Message}");
            }
            return "Ошибка";
        }

        //
        private static string Resultat(List<string> textList)
        {
            textList = Calculate(textList, "*", "/");
            textList = Calculate(textList, "+", "-");
            return textList[0];
        }
    }
}