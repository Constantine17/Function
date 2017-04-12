using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // test symbols
//using Math;


static class Test
{
    public static bool Double(string number)
    {
        if (Regex.IsMatch(number, @"\D") == false || Regex.IsMatch(number, @"[,]")) return true;//проверка числа
        else return false;
    }
}




class Function
{   
    /// //// SIN //// /// {
    public string Sin(string x)
    {
        return "sin(" + x + ")";
    }

    public double Sin(double x)
    {
        return Math.Sin(x);
    }
    /// //// SIN //// /// }
    
    /// //// COS //// /// {
    public string Cos(string x)
    {
        return "cos(" + x + ")";
    }

    public double Cos(double x)
    {
        return Math.Cos(x);
    }
    /// //// COS //// /// }

    /// //// EXP //// /// { 
    public string Exp(string x)
    {
        return "exp(" + x + ")";
    }
    public double Exp(double x)
    {
        return Math.Exp(x);
    }
    /// //// EXP //// /// }

    /// //// Power //// /// {
    public string Power(string a, string x) 
    {
        return a + "^" + x;
    }
    public string Power(double a, string x)
    {
        return a + "^" + x;
    }
    public string Power(string a, double x)
    {
        return a + "^" + x;
    }
    public double Power(double a, double x)
    {
        return Math.Pow(a, x);
    }
    /// //// Power //// /// }
 
    /// //// ln //// /// {
    public string ln(string x)
    {
        return "ln(" + x + ")";
    }
    public double ln(double x)
    {   
        return Math.Log(x);
    }
    /// //// ln //// /// }

    /// //// tg //// /// }
    public string tan(string x)
    {
        return "tg(" + x + ")";
    }
    public double tan(double x)
    {
        return Math.Tan(x);
    }
    /// //// tg //// /// }

    /// //// ctg //// /// }
    public string ctan(string x)
    {
        return "ctg(" + x + ")";
    }
    public double ctan(double x)
    {
        return 1 / Math.Tan(x);
    }
    /// //// ctg //// /// }

}

class Calculation : Function
{
    /// //// Sum //// /// }
    public string Sum(string Lfun, string Rfun)
    {
        return Lfun + "+" + Rfun;
    }
    public string Sum(double Lfun, string Rfun)
    {
        return Lfun + "+" + Rfun;
    }
    public string Sum(string Lfun, double Rfun)
    {
        return Lfun + "+" + Rfun;
    }
    public double Sum(double Lfun, double Rfun)
    {
        return Lfun + Rfun;
    }
    /// //// Sum //// /// }
 
    /// //// Sub //// /// }
    public string Sub(string Lfun, string Rfun)
    {
        return Lfun + "-" + Rfun;
    }
    public string Sub(double Lfun, string Rfun)
    {
        return Lfun + "-" + Rfun;
    }
    public string Sub(string Lfun, double Rfun)
    {
        return Lfun + "-" + Rfun;
    }
    public double Sub(double Lfun, double Rfun)
    {
        return Lfun - Rfun;
    }
    /// //// sub //// /// }

    /// //// Mul //// /// }
    public string Mul(string Lfun, string Rfun)
    {
        return Lfun + "" + Rfun;
    }
    public string Mul(double Lfun, string Rfun)
    {
        return Lfun + "" + Rfun;
    }
    public string Mul(string Lfun, double Rfun)
    {
        return Lfun + "" + Rfun;
    }
    public double Mul(double Lfun, double Rfun)
    {
        return Lfun * Rfun;
    }
    /// //// Mul //// /// }

    /// //// Div //// /// }
    public string Div(string Lfun, string Rfun)
    {
        return (Lfun + "/" + Rfun);
    }
    public string Div(double Lfun, string Rfun)
    {
        return Lfun + "/" + Rfun;
    }
    public string Div(string Lfun, double Rfun)
    {
        return Lfun + "/" + Rfun;
    }
    public double Div(double Lfun, double Rfun)
    {
        return Lfun / Rfun;
    }
    /// //// Mul //// /// }
    

}

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            String string_fun = "x";
            double double_fun = 90;

            Function func = new Function();
            
            Console.WriteLine(func.Cos(double_fun));
            Console.WriteLine(func.Sin(double_fun));
            string_fun = func.ln("x");
            Console.WriteLine(string_fun);
            Calculation culc = new Calculation();
            Console.WriteLine(culc.Div(3,3));
            Console.WriteLine("\n");
          

            while (true)
            {
                string_fun = Console.ReadLine();
                /// sin /// {
                if (Regex.IsMatch(string_fun, @"^sin") && string_fun.Length>5) //проверка фунцкии
                { 
                    string_fun = string_fun.Substring(4, string_fun.Length - 5);// вычетания из строки команду функции
                    if (Test.Double(string_fun)) //проверка числа
                    { Console.WriteLine(func.Sin(Convert.ToDouble(string_fun))); }
                    else Console.WriteLine(func.Sin(string_fun));
                }
                /// sin /// }
                /// 
                /// cos /// {
                if (Regex.IsMatch(string_fun, @"^cos") && string_fun.Length>5) //проверка фунцкии
                {
                    string_fun = string_fun.Substring(4, string_fun.Length - 5);// вычетания из строки команду функции
                    if (Test.Double(string_fun)) //проверка числа
                    { Console.WriteLine(func.Cos(Convert.ToDouble(string_fun)));}
                    else Console.WriteLine(func.Cos(string_fun));
                }
                /// cos /// }
                ///
                /// tg /// {
                if (Regex.IsMatch(string_fun, @"^tan") && string_fun.Length > 5) //проверка фунцкии !!! двух символьная команда
                {
                    string_fun = string_fun.Substring(4, string_fun.Length - 5);// вычетания из строки команду функции
                    if (Test.Double(string_fun)) //проверка числа
                    { Console.WriteLine(func.tan(Convert.ToDouble(string_fun))); }
                    else Console.WriteLine(func.tan(string_fun));
                }
                /// tg /// }
                /// 
                /// ctg /// {
                if (Regex.IsMatch(string_fun, @"^ctan") && string_fun.Length > 6) //проверка фунцкии !!! двух символьная команда
                {
                    string_fun = string_fun.Substring(5, string_fun.Length - 6);// вычетания из строки команду функции
                    if (Test.Double(string_fun)) //проверка числа
                    { Console.WriteLine(func.ctan(Convert.ToDouble(string_fun))); }
                    else Console.WriteLine(func.ctan(string_fun));
                }
                /// ctg /// }
                /// 
                /// Exp /// {
                if (Regex.IsMatch(string_fun, @"^exp") && string_fun.Length > 5) //проверка фунцкии !!! двух символьная команда
                {
                    string_fun = string_fun.Substring(4, string_fun.Length - 5);// вычетания из строки команду функции
                    if (Test.Double(string_fun)) //проверка числа
                    { Console.WriteLine(func.Exp(Convert.ToDouble(string_fun))); }
                    else Console.WriteLine(func.Exp(string_fun));
                }
                /// Exp /// }
                /// 
                /// ln /// {
                if (Regex.IsMatch(string_fun, @"^ln") && string_fun.Length > 4) //проверка фунцкии !!! двух символьная команда
                {
                    string_fun = string_fun.Substring(3, string_fun.Length - 4);// вычетания из строки команду функции
                    if (Test.Double(string_fun)) //проверка числа
                    { Console.WriteLine(func.ln(Convert.ToDouble(string_fun))); }
                    else Console.WriteLine(func.ln(string_fun));
                }
                /// ln /// }
                /// 
                /// Power /// {
                int simbol_number = string_fun.IndexOf('^');// нахождения символа "^"
                if (simbol_number >= 0) // проверка существования символа "^"
                {
                    string Lsimbol = "", Rsimbol = "";
                    Lsimbol = string_fun.Substring(0, string_fun.Length - simbol_number - 1);// отделение левого числа
                    Rsimbol = string_fun.Substring(simbol_number + 1); // отделение правого числа
                    if (Test.Double(Lsimbol) && Test.Double(Rsimbol))// проверка строк на число
                    {Console.WriteLine(func.Power(Convert.ToDouble(Lsimbol), Convert.ToDouble(Rsimbol))); }
                    else Console.WriteLine(func.Power(Lsimbol, Rsimbol));
                }
                /// Power /// }
            }




            /*
            while (true)
            {
                string_fun = Console.ReadLine();
                if (Regex.IsMatch(string_fun, @"\D") == false || Regex.IsMatch(string_fun, @"[.]") == true) Console.WriteLine("true");
                else Console.WriteLine("false");
                
                if (Regex.IsMatch(string_fun, @"[sin(]*[)]$"))  { Console.WriteLine("true"); string_fun = string_fun.Substring(4,string_fun.Length-5); }
                else Console.WriteLine("false");
                Console.WriteLine(string_fun);
                 
            }*/
            Console.ReadKey();
        }
    }
}
