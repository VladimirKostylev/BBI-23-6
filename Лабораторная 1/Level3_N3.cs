using System;

class HelloWorld
{
    static void Main()
    {
        const double a = 0.1, b = 1, h = 0.1, LIMIT = 0.0001;
        int i;
        double s, term;

        for (double x = a; x <= b; x += h)
        {
            i = 1;
            s = 1;
            int factorial = 1;
            do
            {
                factorial *= i;
                term = Math.Cos(i * x) / factorial;
                s += term;
                i++;
            } while (Math.Abs(term) >= LIMIT);

            double y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));

            Console.WriteLine($"x: {x}, s: {s}, y: {y}\n");
        }
    }
}
