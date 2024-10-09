using MyFirstMVC.Models;
using MyFirstMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Controllers
{
    public class TipController
    {
         Display myDisplay = new Display();
         Tip myTip;
     public void Start()
    {
     myDisplay.Input();
     myTip = new Tip(myDisplay.Amount, myDisplay.Percent);
     myDisplay.TipSum = myTip.CalculateTip();
     myDisplay.TotalSum = myTip.CalculateTotal();
     myDisplay.Output();
    }
    }
}
