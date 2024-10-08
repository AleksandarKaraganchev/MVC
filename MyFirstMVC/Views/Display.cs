using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Views
{
    public class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }
        public double TipSum { get; set; }
        public double TotalSum { get; set; }
        public void Input()
        {
            Console.Write("Enter the amount of the check: ");
            double amount = double.Parse(Console.ReadLine());
            this.Amount = amount;
            Console.Write("Enter tip in percentages: ");
            double percent = double.Parse(Console.ReadLine());
            this.Percent = percent;
        }
        public void Output()
        {
            Console.WriteLine($"The tip of for the waiter is {this.TipSum}lv");
            Console.WriteLine($"The check is {this.TotalSum}lv");
        }
    }
}
