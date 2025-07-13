using System.Net.Http.Headers;

namespace CSAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Year Quarter - If Else

            // Console.Write("Enter Month Number Existed in First Quarter : ");
            // int Month;
            // bool Flag = int.TryParse(Console.ReadLine(), out Month);

            // if (Month == 1)
            // {
            //     Console.WriteLine("Hello Jan");
            // }
            // else if (Month == 2)
            // {
            //     Console.WriteLine("Hello Feb");
            // }
            // else if (Month == 3)
            // {
            //     Console.WriteLine("Hello Mar");
            // }
            // else if (Month == 4)
            // {
            //     Console.WriteLine("Hello Apr");
            // }
            // else
            // {
            //     Console.WriteLine("Month Not Existed in First Quarter of Year");
            // }

            #endregion

            #region Year Quarter - Switch Case

            // Console.Write("Enter Month Number Existed in First Quarter : ");
            // int month;
            // bool Flag = int.TryParse(Console.ReadLine(), out month);

            // switch (month)
            // {
            //     case 1:
            //         Console.WriteLine("Jan");
            //         break;
            //     case 2:
            //         Console.WriteLine("Feb");
            //         break;
            //     case 3:
            //         Console.WriteLine("Mar");
            //         break;
            //     case 4:
            //         Console.WriteLine("Apr");
            //         break;
            //     default:
            //         Console.WriteLine("Not Existed !");
            //         break;
            // }

            #endregion

            #region Student Age - If Else

            /*
             * Age > 22 => Student Age Greater Than 22
             * Age < 22 => Student Age Less Than 22
             * Age = 22 => Student Age is 22
             */

            // Console.Write("Enter Student Age : ");
            // int.TryParse(Console.ReadLine(), out int age);

            // if (age > 22)
            //     Console.WriteLine("Student Age is Greater Than 22");
            // else if (age < 22)
            //     Console.WriteLine("Student Age Less Than 22");
            // else
            //     Console.WriteLine("Student Age is 22");

            #endregion

            #region Student Age - Switch Case

            // Console.Write("Enter Student Age : ");
            // int.TryParse(Console.ReadLine(), out int age);

            // switch (age)
            // {
            //     case > 22:
            //         Console.WriteLine("Student Age Greater Than 22");
            //         break;
            //     case < 22:
            //         Console.WriteLine("Student Age Less Than 22");
            //         break;
            //     default:
            //         Console.WriteLine("Student Age is 22");
            //         break;
            // }

            #endregion

            #region Student Name - If Else

            /*
             * Omar  => Hello Omar
             * May   => Hello May
             * Aliaa => Hello Aliaa
             */

            // Console.Write("Enter Name : ");
            // string name = Console.ReadLine() ?? "No Name";

            // if (name == "Omar")
            //     Console.WriteLine("Hello Omar");
            // else if (name == "May")
            //     Console.WriteLine("Hello May");
            // else if (name == "aliaa")
            //     Console.WriteLine("Hello aliaa");
            // else
            //     Console.WriteLine("NOT FOUND !");

            #endregion

            #region Student Name - Switch Case

            //Console.Write("Enter Name : ");
            //string name = Console.ReadLine() ?? "No Name";

            //switch (name)
            //{
            //    case "Omar":
            //        Console.WriteLine("Hello Omar");
            //        break;
            //    case "May":
            //        Console.WriteLine("Hello May");
            //        break;
            //    case "Aliaa":
            //        Console.WriteLine("Hello Aliaa");
            //        break;
            //    default:
            //        break;
            //}

            #endregion

            // ===================== Budget - Goto in Switch =====================

            /*
             * Budget is 1000 => Option 01
             * Budget is 2000 => Option 02 + Option 01
             * Budget is 3000 => Option 03 + Option 02 + Option 01
             */

            //Console.Write("Enter Your Budget : ");
            //int.TryParse(Console.ReadLine(), out int budget);

            //switch (budget)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 01");
            //        Console.WriteLine("Option 02");
            //        Console.WriteLine("Option 03");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 01");
            //        Console.WriteLine("Option 02");
            //        break;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;

            //}



            // Better way

            
            Console.Write("Enter Your Budget : ");
            int.TryParse(Console.ReadLine(), out int budget);

            switch (budget)
            {
                case 3000:
                    goto case 2000;
                    Console.WriteLine("Option 03");
                    
                case 2000:
                    Console.WriteLine("Option 02");
                    goto case 1000;
                case 1000:
                    Console.WriteLine("Option 01");
                    break;

            }







        // ===================== Goto Example =====================


        Retry:
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            if (name == "Mostafa")
            
                goto Retry;
            
            else
            
                Console.WriteLine($"Hello {name}");
            
        }
    }
}
