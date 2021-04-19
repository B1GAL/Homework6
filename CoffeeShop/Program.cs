using System;

namespace CoffeeShop
{
    class Program
    {
        const double TAX_RATE = 0.085; //8.5% babyyyy HUHHUUUHUHUHUHUHUHUHUHUHUHUUUHUHUHUUUHUHUHUUHUHUHUHUHUHUHUHU uhuhuhuhuhuhuhuhuuhuhuhuhuhuh YEYEYEEYYEEYEYEYEYEYEY
        static void Main(string[] args)
        {
            
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

        static void ShowReceipt(double totalPrice)
        {
            double result;
            switch (totalPrice)
            {

            }
        }







    }
}
