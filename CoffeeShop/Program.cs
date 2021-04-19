using System;
using System.Collections.Generic;

namespace CoffeeShop
{
    class Program
    {
        const double TAX_RATE = 0.085; //8.5% babyyyy HUHHUUUHUHUHUHUHUHUHUHUHUHUUUHUHUHUUUHUHUHUUHUHUHUHUHUHUHUHU uhuhuhuhuhuhuhuhuuhuhuhuhuhuh YEYEYEEYYEEYEYEYEYEYEY
        static void Main(string[] args)
        {
            List<string> orderHistory = new List<string>();
            double total = 0;

            string answer;
            do
            {
                string menu = GetMenu();
                Console.WriteLine(menu);

                Console.WriteLine("What would you like to order?");
                answer = Console.ReadLine();
                orderHistory.Add(answer);

                double price = CalculatePrice(answer);
                total += price;
                ShowReceipt(price);

                Console.WriteLine("Would you like to order anything else? Yes or No");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");
            
            Console.WriteLine("/n You Ordered");

            bool isFirstTime = true;

            foreach (string item in orderHistory)
            {
                if (isFirstTime)
                {
                    Console.Write(item);
                    isFirstTime = false;
                }
                else
                {
                    Console.Write("," + item);
                }
                Console.WriteLine();
                Console.WriteLine($"That is a whopping {total.ToString("C")}'s worth of drinks!!");


            }

        }


        static string GetMenu()
        {
            string msg = "    Coffee Shop Menu   " +
                         " Fresh Coffee------ $2.25 "   +
                         " Café au lait------ $3.72 "   +
                         " Latte------ $4.03 "          +
                         " Hot Chocolate ------ $3.51 " +
                         " Pumpkin Spice ------ $7.30 ";
            return msg;
        }               

        static double CalculatePrice(string item)
        {
            double result;
            switch (item.ToUpper())
            {
              case  "Fresh Coffee":
                result = 2.25;
                break;
              case  "Café au lait":
                result = 3.72;
                break;
              case  "Latte":
                result = 4.03;
                break;
              case "Hot Chocolate":
                result = 3.51;
                break;
              case "Pumpkin Spice":
                result = 7.30;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;

        }

        static void ShowReceipt(double subTotal)
        {
            double tax = subTotal * TAX_RATE;
            double total = subTotal + tax;
            Console.Write($"Subtotal for your item(s) is {subTotal.ToString("C")} ");
            Console.WriteLine();
            Console.Write($"Tax for your item(s) is {tax.ToString("C")} ");
            Console.WriteLine();
            Console.Write($"Total for your item(s) is {total.ToString("C")} ");
            Console.WriteLine();

        }







    }
}
