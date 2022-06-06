using System;

namespace Moment2
{
    class Program
    {

        static void Main(string[] args)
        {


            //USER PUTS IN BIRTH DATE
            Console.WriteLine("Vilket är ditt födelsedatum? ÅÅÅÅ-MM-DD");

            //THE DATE TURNS IN TO A VARIABLE
            var birthDate = Console.ReadLine();
            DateTime checkDate;

            //STRING SPLITS INTO YYYY-MM-DD
            string[] y = birthDate.Split('-');
   
            //TO VALIDATE IT'S A DATE THAT IS PUT IN 
            if (DateTime.TryParse(birthDate, out checkDate))
            {
                string year = y[0];
                int d = int.Parse(y[2]);
                int m = int.Parse(y[1]);
                int k = int.Parse(year.Substring(2, 2));
                int h = int.Parse(year.Substring(0, 2));



                //COUNTS THE NUMBERS OF WHICH WEEKDAY IT IS
                if (m < 3) { m += 12; k--; }
                int birthDay = (d + (13 * (m + 1) / 5) + k + (k / 4) + (h / 4) + 5 * h) % 7;



                //DEFINES THE DAYS DEPENDING ON NUMBER ABOVE. 
                switch (birthDay)
                {
                    case 0:
                        Console.WriteLine("Du föddes på en lördag");
                        break;

                    case 1:
                        Console.WriteLine("Du föddes på en söndag");
                        break;

                    case 2:
                        Console.WriteLine("Du föddes på en måndag");
                        break;

                    case 3:
                        Console.WriteLine("Du föddes på en tisdag");
                        break;

                    case 4:
                        Console.WriteLine("Du föddes på en onsdag");
                        break;

                    case 5:
                        Console.WriteLine("Du föddes på en torsdag");
                        break;

                    case 6:
                        Console.WriteLine("Du föddes på en fredag");
                        break;
                }
            }
            //ERROR-MESSAGE IF THE PUT IN DATE IS NOT CORRECT. 
            else
            {
                Console.WriteLine("Du måste ange ett korrekt födelsedatum!");
            }

        }
    }
}