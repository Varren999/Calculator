using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    internal class Result
    {
        public string outStr;

        public Result(string inStr)
        {
            if (inStr.Length > 2)
            {
                inStr = ReplaceString(inStr);
                outStr = Resultat(new List<string>(inStr.Split(' ')));
            }
            else
            {
                inStr = ReplaceString(inStr);
                string[] temp = inStr.Split(' ');
                outStr = Count(temp[0], temp[1], temp[0]);
            }
        }

        // Метод подменяет подстроку с пробелами если пользователь ввел текст без пробелов.
        private string ReplaceString(string text)
        {
            string[] old_simbol = { "+", "-", "*", "/", };
            string[] new_simbol = { " + ", " - ", " * ", " / "};
            for (int i = 0; i < old_simbol.Length; i++)
            {
                text = text.Replace(old_simbol[i], new_simbol[i]);
            }
            return text;
        }

        // Метод убирает пустые строки из массива.
        private string[] EmptyString(string[] Arr)
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
                    //else if(Current.Count > 1)
                    //{

                    //}
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