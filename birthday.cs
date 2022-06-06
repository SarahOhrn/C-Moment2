
// C# program to find Find the Day
// for a Date
using System;

class GFG
{

    // Print Day for a Date
    static void Zellercongruence(int day,
                      int month, int year)
    {
        if (month == 1)
        {
            month = 13;
            year--;
        }
        if (month == 2)
        {
            month = 14;
            year--;
        }
        int q = day;
        int m = month;
        int k = year % 100;
        int j = year / 100;
        int h = q + 13 * (m + 1) / 5 + k + k / 4
                                 + j / 4 + 5 * j;
        h = h % 7;
        switch (h)
        {
            case 0:
                Console.WriteLine("Saturday");
                break;

            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;

            case 4:
                Console.WriteLine("Wednesday");
                break;

            case 5:
                Console.WriteLine("Thursday");
                break;

            case 6:
                Console.WriteLine("Friday");
                break;
        }
    }

    // Driver code
    public static void Main()
    {

        //date (dd/mm/yyyy)
        Zellercongruence(22, 10, 2017);
    }
}