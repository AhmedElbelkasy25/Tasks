using System.Runtime.CompilerServices;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char pressedButton;
            List<int> numbersList = new List<int>();
            Console.WriteLine("\n -----------------------------------------------------");
            Console.WriteLine("\n -----------------------------------------------------");

            Console.WriteLine("sorted array and no duplication"); 
            do
            {
                Console.WriteLine("\n -----------------------------------------------------");
                Console.WriteLine("\n -----------------------------------------------------");
                Console.WriteLine("press : P for print number");
                Console.WriteLine("press : A to add numbers");
                Console.WriteLine("press : M to display the mean of numbers");
                Console.WriteLine("press : S to display the smallest number");
                Console.WriteLine("press : L to display the largest number");
                Console.WriteLine("press : F to search about element index");
                Console.WriteLine("press : C to clear out the list");
                Console.WriteLine("press: Q to out");
                Console.WriteLine("\n -----------------------------------------------------");

                pressedButton = char.Parse(Console.ReadLine());
                Console.WriteLine("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("\n ::::::::::::::::::::::::::::::::::::::::::::::::::::");
                //---------------------------------------------------------------------------
                if (pressedButton == 'p' || pressedButton == 'P')
                {
                    if (numbersList.Count == 0)
                        Console.WriteLine("[]- the list is empty");
                    else
                    {

                        int temp;


                        for (int i = 0; i < numbersList.Count; i++)
                        {

                            for (int j = i + 1; j < numbersList.Count; j++)
                            {

                                if (numbersList[i] > numbersList[j])
                                {
                                    temp = numbersList[j];
                                    numbersList[j] = numbersList[i];
                                    numbersList[i] = temp;
                                }

                            }
                                  
                                
                        }
                        Console.Write("[ ");
                        for (int i = 0; i < numbersList.Count; i++)
                        {
                            Console.Write($"{numbersList[i]} ");

                        }
                        Console.WriteLine("]");
                    }
                }
                //-------------------------------------------------------------------------

                else if (pressedButton == 'A' || pressedButton == 'a')
                {
                    bool isExist = false;
                    int newElement;
                    Console.WriteLine("enter number:-");
                    newElement = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        if (newElement == numbersList[i])
                        {
                            Console.WriteLine("sorry, this number is already exist");
                            isExist = true;
                        }
                    }
                    if (isExist == false)
                    {
                        numbersList.Add(newElement);
                        Console.WriteLine($" {newElement} is added successfully");
                    }
                }
                //-----------------------------------------------------------
                else if (pressedButton == 'M' || pressedButton == 'm')
                {
                    
                    if (numbersList.Count == 0)
                        Console.WriteLine("Unable to calculate the mean - no data");
                    else
                    {
                        int sums = 0;
                        int mean;
                        for (int i = 0; i < numbersList.Count; i++)
                        {
                            sums += numbersList[i];
                        }
                        mean = sums / numbersList.Count;
                        Console.WriteLine($"the mean of numbers is {mean}");
                    }
                }
                //-----------------------------------------------------------------
                else if (pressedButton == 'S' || pressedButton == 's')
                {
                    
                    if (numbersList.Count == 0)
                        Console.WriteLine("unable to determine the smallest number - list is empty");
                    else {
                        int smallestnumber = numbersList[0];
                        for (int i = 1; i < numbersList.Count; i++)
                        {
                            if (smallestnumber > numbersList[i])
                            {
                                smallestnumber = numbersList[i];
                            }
                        }
                        Console.WriteLine($"the smallest number is {smallestnumber}");
                    }
                }
                        

                //-----------------------------------------------------------------
                else if (pressedButton == 'L' || pressedButton == 'l')
                {

                    if (numbersList.Count == 0)
                        Console.WriteLine("unable to determine the largest number - list is empty");
                    else {
                        int largestnumber = numbersList[0];
                        for (int i = 1; i < numbersList.Count; i++)
                        {
                            if (largestnumber < numbersList[i])
                            {
                                largestnumber = numbersList[i];
                            }
                        }
                        Console.WriteLine($"the largest number is {largestnumber}");
                    }
                       
                }
                //-----------------------------------------------------------------
                else if (pressedButton == 'C' || pressedButton == 'c')
                {
                    if (numbersList.Count == 0)
                        Console.WriteLine("[]- the list is empty");
                    else {
                        numbersList.Clear();
                        Console.WriteLine("the list is cleared successfully");
                    }
                    
                }
                //-----------------------------------------------------------------
                else if (pressedButton == 'F' || pressedButton == 'f')
                {
                    
                    if (numbersList.Count == 0)
                        Console.WriteLine("[]- the list is empty");
                    else
                    {
                        int numToCheck;
                        bool isExist = false;
                        Console.WriteLine("enter the number you want to check...");
                        numToCheck = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numbersList.Count; i++)
                        {
                            if (numToCheck == numbersList[i])
                            {
                                Console.WriteLine($"the {numToCheck} is exist at index {i}");
                                isExist = true;
                            }

                        }

                        if (isExist != true)
                            Console.WriteLine($"{numToCheck} is not exist in the list");
                    }


                }
                //-----------------------------------------------------------------
                else if (pressedButton == 'Q' || pressedButton == 'q')
                {
                    Console.WriteLine("GoodBye");
                    break;
                }
                else {
                    Console.WriteLine("unknown choice !");
                }
            } while (pressedButton != 'Q' || pressedButton != 'q');



            //int[] nums = [44,78,96,55,24,71,425,638,475,4];
            //int temp;


            //for (int i = 0; i < nums.Length; i++) {

            //    for (int j = i+1; j < nums.Length; j++) {
            //        temp = 0;
            //        if (nums[i] > nums[j])
            //        {
            //            temp = nums[j];
            //            nums[j] = nums[i];
            //            nums[i] = temp;

            //        } 
            //    }
            //    Console.WriteLine(nums[i]);
            //}
        }
    }
}
