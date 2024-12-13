using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;

namespace Route._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region   Demo
            #region   value type

            #region implicit casting - safe casting 
            //int x = 4; // 4 byte
            //long y =/*(long)*/ x;
            #endregion

            #region Explicit Casting - unsafe Casting
            //long x = 101010101010101010; //8byte
            //int y = x;  /*Error*/
            // // 
            // checked
            //{
            //    int y = (int)x; /*the command will give you exception so that is wrong */
            //}
            //Console.WriteLine(y);
            //int x = 88;
            //double y = /*(double)*/x;  /*implicit*/
            // // 

            //double x = 88.878;
            //int y = (int) x;          /*Explicit unsaved one */
            #endregion

            #region Parse [convert from string to any datatype]

            //int Number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter user ");

            //Console.Write("Enter Name : ");
            //string Name = Console.ReadLine();

            //Console.Write("Enter your Age ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write(" Enter Salary ");
            //double salary = double.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name : "+ Name  + " Age "+Age + " Salary "+salary);
            #endregion

            #region Convert [ convert from any Datatype  to any datatype]
            //Console.WriteLine("Enter user ");

            //Console.Write("Enter Name : ");
            //string Name = Console.ReadLine();

            //Console.Write("Enter your Age ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write(" Enter Salary ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name : " + Name + " Age " + Age + " Salary " + salary);
            #endregion


            #endregion

            #region Operators 
            #region unary [++,--]
            //int x = 5;
            //// x++ , x-- => prefix
            //// ++x , --x => postfix 
            //Console.WriteLine(x++);
            //Console.WriteLine(++x);
            //Console.WriteLine(x--);
            //Console.WriteLine(--x);

            #endregion

            #region Binary 

            //int Sum, Mul, Sub, Div, Mod;

            //int a = 10; 
            //int b = 5;

            //Sum = a+b;
            //Mul = a*b;
            //Sub = a-b;
            //Div = a/b;
            //Mod = a%b;

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul); 
            //Console.WriteLine(Sub);
            //Console.WriteLine(Div);
            //Console.WriteLine(Mod);


            #endregion

            #region Assignment 
            //int x = 10;
            //x += 10;
            //x -= 10;
            //x %= 10;
            //x *= 10;
            //x /= 10;

            #endregion

            #region Relational 
            //int A = 0;
            //int B = 10;

            //Console.WriteLine(A == B);
            //Console.WriteLine(A != B);
            //Console.WriteLine(A <= B);
            //Console.WriteLine(A >= B);
            //Console.WriteLine(A < B);
            //Console.WriteLine(A > B);

            #endregion

            #region logical 
            //Console.WriteLine(true && false); [Short Circuit]
            ////  true && true = true 
            //    true && false = false
            //    false && true = false
            //    false && false = false
            /////////////////////////
            ////  true || true = true 
            //    true || false = false
            //    false || true = false
            //    false || false = false
            /////////////////////////////////////////////////////////
            //Console.WriteLine(true && false); [long Circuit]
            ////  true & true = true 
            //    true & false = false
            //    false & true = false
            //    false & false = false
            /////////////////////////
            ////  true | true = true 
            //    true | false = false
            //    false | true = false
            //    false | false = false

            #endregion

            #region Ternary 
            //int x = 4;

            //string message = x > 4 ? " X greater than4 " : " X less than 4";
            #endregion

            #region Operator periorety 

            //int a = 5 ; 
            //int b = 6; 
            //int c = 7; 
            //int d = 8;

            //int result;

            //result = (a + b) * c / d; /* between bracet will be accomplish first then * then / */

            #endregion

            #region String Formating 
            //    int x = 0;
            //    int y = 10;
            //    int result = x+y;
            //Console.WriteLine("Equation :"+x + " + " + y +" = " + result);
            ///* it works but not efficient */
            ///

            /*to be fixed there are two ways */

            #region Composite Formate
            //int x = 0;
            //int y = 10;
            //int result = x + y;
            //string message = string.Format("Equation  = {0} + {1} = {2}",x,y,result);
            //Console.WriteLine(message);
            //Console.WriteLine("Equation  = {0} + {1} = {2}", x, y, result);


            #endregion

            #region String Manipolition
            //int x = 0;
            //int y = 10;
            //int result = x + y;

            //Console.WriteLine($"Equation = {x} + {y} = {result}");

            #endregion


            #endregion

            #region IF - Else - Switch Case 
            /*if-statment*/

            //Console.WriteLine("Enter Month Number");

            //int MonthNum = int.Parse(Console.ReadLine());

            //if (MonthNum==1)
            //{
            //    Console.WriteLine("Month is Jan");
            //}
            //else if (MonthNum==2) 
            //{
            //    Console.WriteLine("Month is Feb");
            //}
            //else if (MonthNum == 3)
            //{
            //    Console.WriteLine("Month is Mar");
            //}
            //else
            //{
            //    Console.WriteLine("not valid "); 
            //}


            /*Switch Case*/
            //Console.WriteLine("Enter Month Number");

            //int MonthNum = int.Parse(Console.ReadLine());

            //switch (MonthNum )
            //{
            //    case 1:
            //        Console.WriteLine("Month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //    default:
            //        Console.WriteLine("not valid ");
            //        break;
            //}

            #endregion

            #region goto [in Switch case]
            //int option = int.Parse(Console.ReadLine())

            //switch (option)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        goto case 2000;

            //    case 2000:
            //        Console.WriteLine("option 02");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //    default:
            //        Console.WriteLine("not valid ");
            //        break;
            //}
            #endregion

            #region Evaluation in C# 
            /*in C# 6 */

            //int Age = int.Parse(Console.ReadLine());

            //switch (Age)
            //{
            //    case > 22 :
            //        Console.WriteLine("greater than 22");
            //        break;

            //    case <22:
            //        Console.WriteLine("less than 22");
            //        break; 

            //    default:
            //        Console.WriteLine(" Equal 22 ");
            //        break;
            //}

            /**********************************************/

            /*C# 7 */
            //object obj = new object();
            //obj = "ali";
            //obj = 18;
            //obj = true;



            //switch (obj)
            //{
            //    case int Num when Num > 30 && Num <15 : 
            //        Console.WriteLine($"{Num} is int ");
            //        break;

            //    case string Name:
            //        Console.WriteLine($"{Name} is Name ");
            //        break; 

            //    case bool Flag:
            //        Console.WriteLine($"{Flag} is bool ");
            //        break;

            //}

            /*************************************************/

            /*c# 08*/
            //Console.WriteLine("");
            //int option = int.Parse(Console.ReadLine());

            //string message = option switch
            //{
            //    1 => "option 01",
            //    2 => "option 02",
            //    3 => "option 03",
            //    _ => "Invalid"
            //}; 

            //Class1 Eo1 = new Class1();
            //Eo1.Name = "ali";
            //Eo1.Id = 5050;
            //Eo1.Age = 22;
            //string message = Eo1 switch
            //{
            //    { Id: 5050, Name: "aliaa", Age: 22 } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}",
            //    { Id: 5050, Name: "ahmed", Age: 22 } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}",
            //    { Id: 5050, Name: "mostafa", Age: 22 } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}"

            //};
            //Console.WriteLine(message);


            /*C# 9 */

            //Class1 Eo1 = new Class1();
            //Eo1.Name = "ali";
            //Eo1.Id = 5050;
            //Eo1.Age = 22;
            //string message = Eo1 switch
            //{
            //    {  Age: 22 and 25 } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}",
            //    {  Age: 22 or 30  } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}",
            //    {  Age: 22  } => $"{Eo1.Id} : {Eo1.Name} : {Eo1.Age}"

            //};
            //Console.WriteLine(message);



            #endregion


            #endregion

            #endregion

            #region Assignment 3
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Enter a Number :");
            //int Number = int.Parse(Console.ReadLine());
            //if (Number % 3 == 0 && Number % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter a Number");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //if (Number < 0)
            //{
            //    Console.WriteLine("negative number");
            //}
            //else
            //{
            //    Console.WriteLine("positive number");
            //}
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Enter the first Number: ");
            //int Number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second Number: ");
            //int Number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Third Number: ");
            //int Number3 = int.Parse(Console.ReadLine());
            //int Max = Math.Max(Number1, Math.Max(Number2, Number3));
            //int Min = Math.Min(Number1, Math.Min(Number2, Number3));

            //Console.WriteLine($"Max element: = {Max}");
            //Console.WriteLine($"Min element: = {Min}");


            //Console.WriteLine("Enter the first Number: ");
            //int Number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second Number: ");
            //int Number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Third Number: ");
            //int Number3 = int.Parse(Console.ReadLine());
            //int Max = Number1;
            //int Min = Number1;

            //if (Number2 > Max)
            //{
            //    Max = Number2;
            //}
            //if (Number2 < Min)
            //{
            //    Min = Number2;
            //}
            //if (Number3 > Max)
            //{
            //    Max = Number3;
            //}
            //if (Number3 < Min)
            //{
            //    Min = Number3;
            //}
            //Console.WriteLine($"Max element: = {Max}");
            //Console.WriteLine($"Min element: = {Min}");
            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Enter a Number :");
            //int Number =int.Parse(Console.ReadLine());
            //if (Number % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Enter a Character");
            //char Character =Convert.ToChar(Console.ReadLine().ToLower());
            //switch (Character)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}
            #endregion

            #region 7- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            //Console.Write("Enter a number: ");
            //int Number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{Number} x {i} = {Number * i}");
            //}
            #endregion

            #region 9- Write a program that takes two integers then prints the power.
            //Console.Write("Enter the base number: ");
            //int baseNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //double result = Math.Pow(baseNumber, exponent);
            //Console.WriteLine($"{baseNumber} the power of --> {exponent} is {result}");

            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage

            //Input: -Enter Marks of five subjects: 95 76 58 90 89


            //int[] Marks = new int[5];
            //int Total = 0;


            //Console.WriteLine("Enter marks of five subjects:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Marks[i] = int.Parse(Console.ReadLine());
            //    Total += Marks[i];
            //}

            //double Average = Total / 5.0;
            //double Percentage = (Total / 500.0) * 100;

            //Console.WriteLine($"Total marks = {Total}");
            //Console.WriteLine($"Average marks = {Average}");
            //Console.WriteLine($"Percentage = {Percentage}");
            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter the month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());
            //int days;
            //switch (month)
            //{
            //    case 1: // January
            //    case 3: // March
            //    case 5: // May
            //    case 7: // July
            //    case 8: // August
            //    case 10: // October
            //    case 12: // December
            //        days = 31;
            //        break;
            //    case 4: // April
            //    case 6: // June
            //    case 9: // September
            //    case 11: // November
            //        days = 30;
            //        break;
            //    case 2: // February
            //        Console.Write("Enter the year: ");
            //        int year = int.Parse(Console.ReadLine());
            //        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //        {
            //            days = 29;
            //        }
            //        else
            //        {
            //            days = 28;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return;
            //}
            //    Console.WriteLine($"Number of days in month {month} is {days}.");

            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter the x y of the first point");
            //int[] pointone = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int P1x = pointone[0];
            //int P1y = pointone[1];
            //Console.WriteLine("Enter the x y of the second point");
            //int[] pointtwo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int P2x = pointtwo[0];
            //int P2y = pointtwo[1];
            //Console.WriteLine("Enter the x y of the third point");
            //int[] pointthree = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int P3x = pointthree[0];
            //int P3y = pointthree[1];

            //double M1_P1_P2 = P2y - P1y / P2x - P1x;
            //double M2_P2_P3 = P3y - P2y / P3x - P2x;

            //if (M1_P1_P2 == M2_P2_P3) Console.WriteLine("these points lie on a single straight line.");
            //else Console.WriteLine("these points did not lie on a single straight line.");
            #endregion

            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows:

            //Console.Write("Enter the time taken to complete the task (in hours): ");
            //double timeTaken = double.Parse(Console.ReadLine());

            //if (timeTaken >= 2 && timeTaken < 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (timeTaken >= 3 && timeTaken < 4)
            //{
            //    Console.WriteLine("The worker needs to increase their speed.");
            //}
            //else if (timeTaken >= 4 && timeTaken <= 5)
            //{
            //    Console.WriteLine("The worker needs training to improve their speed.");
            //}
            //else if (timeTaken > 5)
            //{
            //    Console.WriteLine("The worker needs to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a time between 2 and 5 hours.");
            #endregion

            #region 21- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int a = 5; // Declare and initialize variable a
            //int b = a;  // Assign the value of a to b

            //Console.WriteLine("Before modifying:");
            //Console.WriteLine($"a ={a}"); // Output: a = 5
            //Console.WriteLine($"b ={b}"); // Output: b = 5

            //b = 10; // Modify the value of b

            //Console.WriteLine("After modifying:");
            //Console.WriteLine($"a ={a}"); // Output: a = 5
            //Console.WriteLine($"b ={b}"); // Output: b = 10
            #endregion

            #region 22-  Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //// Create a new Person object
            //Person person1 = new Person();
            //person1.Name = "Sameh";
            //// Assign person1 to person2
            //Person person2 = person1;
            //Console.WriteLine("Before Modifying:");
            //Console.WriteLine($"person1.Name:={person1.Name}"); //Output: person1.Name = Sameh
            //Console.WriteLine($"person2.Name:={person2.Name}"); //Output: person2.Name = Sameh

            //person2.Name = "Mohamed";

            //Console.WriteLine("After Modifying:");
            //Console.WriteLine($"person1.Name:={person1.Name}");//Output: person1.Name = Mohamed
            //Console.WriteLine($"person2.Name:={person2.Name}");//Output: person1.Name = Mohamed
            #endregion

            #region 23-  Which of the following statements is correct about the C#.NET code snippet given below?

            // b)-->  A value 1 will be assigned to d.
            //Explanation:
            //-->30 < 20 evaluates to false because 30 is not less than 20.
            //!(30 < 20) applies the logical NOT operator !to false, which results in true.
            //Convert.ToInt32(true) converts the boolean value true to the integer 1.

            #endregion

            #region 24-  Which of the following is the correct output for the C# code given below?

            //d) --> 6 1

            //Explanation:

            //Division:
            //13 / 2 performs integer division because both operands are integers.
            //The result of 13 / 2 is 6(since integer division discards the decimal part).

            //Modulus :
            //13 % 2 calculates the remainder of the division of 13 by 2.
            //The result of 13 % 2 is 1.

            //String Concatenation:
            //The results of the division and modulus operations are concatenated with a space in between.
            //The final output is "6 1"
            #endregion

            #region 25-  What will be the output of the C# code given below? 
            //d)--> 7 7
            //int num = 1, z = 5;

            //if (!(num <= 0))//=> !false = true 
            // Console.WriteLine(++num + z++ + " " + ++z);
            //else
            // Console.WriteLine(--num + z-- + " " + --z);

            ////the condition will be true so the first console will appear 

            #endregion

            #endregion
        }
    }
    
}
