using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            item item1=new item();
            item1.name = "Nazrul";//get
            item1.unitPrice = 23;//get
            string nameofItem = item1.name;
            double unitpriceofItem = item1.unitPrice;
            
            
            item item2 = new item();
            item2.name = "Rahim";
            item2.unitPrice = 40;
            string namefItem = item2.name;
            double unitpricefItem = item2.unitPrice;

            Console.WriteLine(namefItem+" "+unitpricefItem);
            Console.WriteLine(nameofItem + " " + unitpriceofItem);
        }
    }
}
