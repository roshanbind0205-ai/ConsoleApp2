
using System;

public class NamePattern
{
    public void PrintPattern()
    {
        int n = 7;
        bool condition;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                condition = (j == 1) || (i == 1 && j <= 4) || (i == 4 && j <= 4) || (j == 5) && (i <= 3) && (i > 1) || (i == j + 2 && i >= 4);

                if (condition)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            for (int j = 1; j <= n; j++)
            {
                condition = (j == 1) && (i >= 2) && (i <= 6) || (i == 1) && (j >= 2) && (j <= 4) || (j == 5) && (i >= 2) && (i <= 6) || (i == 7) && (j <= 4) && (j >= 2);

                if (condition)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            for (int j = 1; j <= n; j++)
            {
                condition = (i == 1) && (j >= 2) && (j <= 5) || (j == 1) && (i >= 2) && (i <= 3) || (i == 4) && (j <= 4) && (j >= 2) || (j == 5) && (i >= 5) && (i <= 6) || (i == 7) && (j <= 4);

                if (condition)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            for (int j = 1; j <= n; j++)
            {
                condition = (j == 1) || (j == 5) || (i == 4) && (j <= 4);

                if (condition)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            for (int j = 1; j <= n; j++)
            {
                condition = (j == 1) && (i >= 2) || (j == 5) && (i >= 2) || (i == 1) && (j <= 4) && (j >= 2) || (i == 4) && (j <= 5);

                if (condition)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            for (int j = 1; j <= n; j++)
            {
                condition = (j == 1) || (j == n) || (i == j);

                if (condition)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            Console.WriteLine();
        }
    }
}