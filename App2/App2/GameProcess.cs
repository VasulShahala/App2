using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public class GameProcess : TabbedPage
    {
        
        public GameProcess()
        {
            


            var navigationPage2 = new NavigationPage(new DayPartGame());

            navigationPage2.Title = "ДЕНЬ";


            var navigationPage3 = new NavigationPage(new NightPartGame());

            navigationPage3.Title = "НІЧ";


            var navigationPage4 = new NavigationPage(new DonsPartGame());

            navigationPage4.Title = "ГРА ДОНА";

            var navigationPage5 = new NavigationPage(new SherifGamePart());

            navigationPage5.Title = "ГРА ШЕРИФА";

            //  Children.Add(navigationPage);
            Children.Add(navigationPage2);
            Children.Add(navigationPage3);
            Children.Add(navigationPage4);
            Children.Add(navigationPage5);

        }
    }
}
