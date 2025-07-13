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

        #region Budget - Goto in Switch (Simple Version)

        /*
         * Budget is 1000 => Option 01
         * Budget is 2000 => Option 02 + Option 01
         * Budget is 3000 => Option 03 + Option 02 + Option 01
         */

        // Console.Write("Enter Your Budget : ");
        // int.TryParse(Console.ReadLine(), out int budget);

        // switch (budget)
        // {
        //     case 3000:
        //         Console.WriteLine("Option 01");
        //         Console.WriteLine("Option 02");
        //         Console.WriteLine("Option 03");
        //         break;
        //     case 2000:
        //         Console.WriteLine("Option 01");
        //         Console.WriteLine("Option 02");
        //         break;
        //     case 1000:
        //         Console.WriteLine("Option 01");
        //         break;
        // }

        #endregion

        #region Budget - Goto in Switch (Improved Version)

        // Console.Write("Enter Your Budget : ");
        // int.TryParse(Console.ReadLine(), out int budget);

        // switch (budget)
        // {
        //     case 3000:
        //         Console.WriteLine("Option 03");
        //         goto case 2000;

        //     case 2000:
        //         Console.WriteLine("Option 02");
        //         goto case 1000;

        //     case 1000:
        //         Console.WriteLine("Option 01");
        //         break;
        // }

        #endregion

        #region Goto Example

        Retry:
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            if (name == "Mostafa")
                goto Retry;
            else
                Console.WriteLine($"Hello {name}");

            #endregion

            #region Patter Matching 
            //object number = 5.6;
            //switch (number)
            //{
            //    case int Value:
            //        Console.WriteLine($"{Value} is integer");
            //        break;
            //    case double Value:
            //        Console.WriteLine($"{Value} is double");
            //        break;
            //        case String Value:
            //        Console.WriteLine($"{Value} is String");
            //        break;
            //        default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}
            #endregion

            #region Patter Matching & Case Guards
            object number = 5.6;
            switch (number)
            {
                case int Value when Value < 10 && Value > 5:
                    Console.WriteLine($"{Value} is integer");
                    break;
                case double Value:
                    Console.WriteLine($"{Value} is double");
                    break;
                case String Value:
                    Console.WriteLine($"{Value} is String");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            #endregion

            #region example 03 [user definded datatype ] 
            object Input = new Person { Id = 10, Name = "Ahmed", Age = 20 };
            switch (Input)
            {
                case int Value:
                    Console.WriteLine($"{Value} is integer");
                    break;
                case double Value:
                    Console.WriteLine($"{Value} is double");
                    break;
                case String Value:
                    Console.WriteLine($"{Value} is String");
                    break;
                case Person Value:
                    Console.WriteLine("I'm a person");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            #endregion

            #region Switch C# 8.0 [New Feature]

            Console.Write("Enter Your Option (1 , 2 , 3) : ");
            string option = Console.ReadLine();
            string Msg = string.Empty; // " "

            //switch (option)
            //{
            //    case "1":
            //        Msg = "Option 1";
            //        break;
            //    case "2":
            //        Msg = "Option 2";
            //        break;
            //    case "3":
            //        Msg = "Option 03";
            //        break;
            //    default:
            //        Msg = "No Option Found !";
            //        break;
            //}


            //another way 

            //Msg = option switch // 3
            //{
            //    "1" => "Option 1",
            //    "2" => "Option 2",
            //    "3" => "Option 3",
            //    _ => "No Option Found !"
            //};

            //Console.WriteLine(Msg);

            #endregion

            #region Proberty pattern
            //Person person = new Person { Id = 10, Age = 25 ,Name ="Ahmed"};
            //String Message = person switch
            //{
            //    { Name: "Ahmed", Age: 10 } => "Hello Ahmed",
            //    { Name: "Omar" } => "Hello Omar",
            //};

            #endregion

            #region Example 04 nullable type relational patterns [partially]
            //int? Number = 10;
            //string Result = Number switch
            //{
            //    null => "null value",
            //    int X when X > 0 => "Positive ",
            //    int X when X < 0 => "Negative ",
            //    _=> "Invalid",
            //};
            #endregion

            #region C#9 switch with relational patterns
            int Number = 20;
            string Message = Number switch
            {
                < 10 => "less than 10 ",
                >= 10 and <= 20 => "Between 10 and 20",
                > 20 or < 10 => "outside range 20",
            };

            Console.WriteLine(Message);
            #endregion

        }
    }
}
