using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int mod1;
            int mod2;
            int ctr = 1;
       
            Console.WriteLine("Press Enter to Generate Random Numbers");
            Console.WriteLine("Dice 1: " + dice1);
            Console.WriteLine("Dice 2: " + dice2);

            for (int u = 0; u < ctr; u++) //to loop 1 time
            {
                //condition to get and to print the value of dice 1, and loop it to 3 asterisk
                if (dice1 == 6) 
                {


                    for (int i = 1; i <= 3; i++)
                    {
                        Console.Write("*");

                    }
                }
                if (dice1 == 5)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                }

                if (dice1 == 4)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                }
                //getting the value of dice 1 less than to 4
                if (dice1 == 3)
                {
                    for (int x = 1; x <= dice1; x++)
                    {
                        Console.Write("*");
                    }
                }
                else if (dice1 == 2)
                {
                    for (int o = 1; o <= dice1; o++)
                    {
                        Console.Write("*");
                    }
                }
                else if (dice1 == 1)
                {
                    for (int b = 1; b <= dice1; b++)
                    {
                        Console.Write("*");
                    }
                }

                //space in the first line
                for (int sp = 0; sp < 1; sp++)
                {
                    Console.Write(" ");
                }
                //condition to get and to print the value of dice 2, and loop it to 3 asterisk
                if (dice2 == 6)
                {


                    for (int i = 1; i <= 3; i++)
                    {
                        Console.Write("*");

                    }
                }
                if (dice2 == 5)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                }

                if (dice2 == 4)
                {

                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write("*");

                    }
                }
                //getting the value of dice2 less than to 4
                if (dice2 == 3)
                {
                    for (int x = 1; x <= dice2; x++)
                    {
                        Console.Write("*");
                    }
                }
                else if (dice2 == 2)
                {
                    for (int o = 1; o <= dice2; o++)
                    {
                        Console.Write("*");
                    }
                }
                else if (dice2 == 1)
                {
                    for (int b = 1; b <= dice2; b++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();//second line


                //condition to get and to print the remaining value of dice 1, and loop it to the dice1 value and print corresponding asterisk
                if (dice1 == 6)
                {
                    mod1 = dice1 / 2;//formula for getting the remaining value of dice1
                    dice1 = mod1;
                    if (dice1 == 3)
                    {

                        for (int i = 1; i <= dice1; i++) 
                        {
                            Console.Write("*");

                        }
                    }
                    for (int sp = 0; sp < 1; sp++)// Space between the 2nd dice
 {
                        Console.Write(" "); 
                    }
                }

                else if (dice1 == 5)
                {
                    
                    mod1 = dice1 - 3; //formula for getting the remaining value of dice1
                    dice1 = mod1;
                    
                    if (dice1 ==2)
                    {
                        for (int j = 1; j <= dice1; j++)
                        {
                            Console.Write("*");

                        }
                       
                    }

                    while (dice1 == 2)  //condititon for the space between dice 1 and dice 2
                    {
                        for (int i = 1; i <= 2; i++)
                        {
                            Console.Write(" ");
                        }
                        break;
                    }

                }
                else if (dice1 == 4)
                {
                   
                    mod1 = dice1 - 3;//formula for getting the remaining value of dice1
                    dice1 = mod1;
                    if (dice1 == 1)
                    {

                        for (int j = 1; j <= dice1; j++)
                        {
                            Console.Write("*");

                        }
                      
                    }
                    while (dice1 == 1)//condititon for the space between dice 1 and dice 2
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            Console.Write(" ");
                        }
                        break;
                    }
                }
                else if (dice1==3){
                    while (dice1 == 3) //condititon for the space between dice 1 and dice 2
                    {
                        for (int i = 1; i <=4; i++)
                        {
                            Console.Write(" ");
                        }
                        break;
                    }
                }
                else if (dice1 == 2)
                {
                    while (dice1 == 2) //condititon for the space between dice 1 and dice 2
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            Console.Write(" ");
                        }
                        break;
                    }
                }
                else if (dice1 == 1)
                {
                    while (dice1 == 1) //condititon for the space between dice 1 and dice 2
                    {
                        for (int i = 1; i <= 2; i++)
                        {
                            Console.Write(" ");
                        }
                        break;
                    }
                }



                //condition to get and to print the remaining value of dice 2, and loop it to the dice2 value and print corresponding asterisk
                if (dice2 == 6)

                        {

                    mod2 = dice2 / 2;//formula for getting the remaining value of dice2
                    dice2 = mod2;
                       
                            if (dice2 == 3) 
                            {
                                for (int i = 1; i <=dice2; i++)
                                {
                                    Console.Write("*");

                                }
                            }
                    
                         }
                        else if (dice2 == 5)
                        {
                   
                    mod2 = dice2 - 3;//formula for getting the remaining value of dice2
                    dice2 = mod2;

                      
                            if (dice2 == 2)
                            {

                                for (int j = 1; j <= dice2; j++)
                                {
                                    Console.Write("*");

                                }
                            }
                        }
                        else if (dice2 == 4)
                        {
                    
                    mod2 = dice2 - 3;//formula for getting the remaining value of dice2
                    dice2 = mod2;
                   
                    if (dice2 == 1)
                            {
                                for (int j = 1; j <= dice2; j++)
                                {
                                    Console.Write("*");

                                }
                            }
                        }
                        Console.WriteLine();
                }
        }
    }
}