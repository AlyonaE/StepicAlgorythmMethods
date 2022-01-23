using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int Fn2 = 0;
        int Fn1 = 1;
        for (int i = 2; i <= n; i++)
        {
            int tmp = Fn1;
            Fn1 = Fn1 + Fn2;
            Fn2 = tmp;
        }
        Console.WriteLine(Fn1);
    }
}