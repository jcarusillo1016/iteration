//Name: Joseph Carusillo    
//Date: 9/12/2019
//Project: Iterative Statement
//Description: write an intereatie statement(loop) for a (Do While, For, or While) ask the user for an integer between 1-100 then display a message to the user

using System;

namespace ClassProject_Deliverable2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            //instructions to tell user what to input into the window
            Console.WriteLine("Enter an Integer between 1-100 below to start the iteration");

            // a try/catch to handle possible errors that can occur and will give error message to user
            try
            {
                // this variable will take the input the user provides
                string input = Console.ReadLine();
                //this variable will be used in the iteration
                int value_input = int.Parse(input);

                // if statement for user input for values between 1-100 to execute the loop
                if((value_input >0) && (value_input <=100))
                {

                    for(int i = 0; i < value_input; i++)
                    {
                        Console.WriteLine("You have entered" + value_input.ToString());
                        Console.WriteLine(" ");
                        Console.WriteLine("This is the current nteger value in the loop:" + value_input.ToString());
                    }
                       Console.ReadKey();                                                                                                                     
                }
                else
                {
                    Console.WriteLine(" please enter an integer between 1-100");
                }
                
            }
            //catch statemetn to handle errors
            catch
            {
                // error messages
                Console.WriteLine("An error has occured");
                Console.WriteLine("Please enter a integer between 1-100");
            }
            //used to keep the window open after th ecomputation is complete
            Console.ReadKey();
        }
    }
}
