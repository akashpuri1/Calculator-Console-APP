using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string heading = "***Calculator***", choice = "Y";
            int read;
            double sum, number1, number2; ;
            Console.SetCursorPosition((Console.WindowWidth - heading.Length) / 2, Console.CursorTop);
            Console.WriteLine(heading);

            while (true)
            {
                if (choice == "Y")
                {
                    try
                    {
                        Console.WriteLine($"{Environment.NewLine}Enter the First Number:");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{Environment.NewLine}Enter the Second Number:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{Environment.NewLine}Please Select the Data Operator you want to use");
                        Console.WriteLine("1. Addition");
                        Console.WriteLine("2. Subtraction");
                        Console.WriteLine("3. Multiplication");
                        Console.WriteLine("4. Divide");

                        try
                        {
                            read = Convert.ToInt32(Console.ReadLine());

                            switch (read)
                            {
                                case 1:
                                    sum = number1 + number2;
                                    Console.WriteLine($"{Environment.NewLine}You! selected Addition Function, Answer: {sum}");
                                    Console.ReadLine();
                                    break;

                                case 2:
                                    sum = number1 - number2;
                                    Console.WriteLine($"{Environment.NewLine}You! selected Subtraction Function, Answer: {sum}");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    sum = number1 * number2;
                                    Console.WriteLine($"{Environment.NewLine}You! selected Multiplication Function, Answer: {sum}");
                                    Console.ReadLine();
                                    break;

                                case 4:
                                    sum = number1 / number2;
                                    Console.WriteLine($"{Environment.NewLine}You! selected Divide Function, Answer: {sum}");
                                    Console.ReadLine();
                                    break;

                                default:
                                    Console.WriteLine("Enter a Valid ID");
                                    break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Enter a Valid Number!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please! Enter a valid Number.");
                    }
                }
                else if (choice == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Please! Press Y to Calculate or N to Exit");
                    }
                    catch { }
                }
                Console.WriteLine("Press Y to Calculate or N to Exit");
                choice = Console.ReadLine();
            }
        }
    }
}