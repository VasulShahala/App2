using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public class NightPartGame : ContentPage
    {

        Xamarin.Forms.Button btn = new Button();
       

        public Button[] actionbtn = new Button[10];
        public Xamarin.Forms.Label[] actionlbl = new Xamarin.Forms.Label[10];
        public Entry[] actionentry = new Entry[10];
        public NightPartGame()
        {



            Xamarin.Forms.Label titlelabel = new Xamarin.Forms.Label();
            titlelabel.Text = "Ніч";
            titlelabel.HorizontalTextAlignment = TextAlignment.Center;
            titlelabel.TextColor = Color.Red;
            titlelabel.FontSize = 18;
            titlelabel.BackgroundColor = Color.White;
            titlelabel.HeightRequest = 25;
            titlelabel.WidthRequest = 150;
            titlelabel.VerticalTextAlignment = TextAlignment.Center;
           
            Xamarin.Forms.Grid grid = new Grid()
            {
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Center,

                RowDefinitions =
                {
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35},
                    new RowDefinition { Height = 35}

                },

                ColumnDefinitions =
                {
                    new ColumnDefinition {Width =20 },
                    new ColumnDefinition {Width = 160  },
                    new ColumnDefinition {Width = 50  }


                }



            };


            for (int i = 0; i < 10; i++)
            {
                grid.Children.Add(actionlbl[i] = new Xamarin.Forms.Label
                {
                    VerticalTextAlignment = TextAlignment.Center,
                    BackgroundColor = Color.White,
                    TextColor = Color.Red,
                    Text = (i + 1).ToString(),
                    FontSize = 14,
                    HeightRequest = 35,
                    WidthRequest = 50
                }, 0, i);
            }



            for (int i = 0; i < 10; i++)
            {
                grid.Children.Add(actionentry[i] = new Entry
                {
                    HeightRequest = 16,
                    WidthRequest = 151,
                    TextColor = Color.Red,
                    FontSize = 14,
                    HorizontalTextAlignment = TextAlignment.Start,
                    Placeholder = "Player_" + (i + 1).ToString(),
                    PlaceholderColor = Color.Black

                }, 1, i);

            }



            for (int i = 0; i < 10; i++)
            {
                grid.Children.Add(actionbtn[i] = new Button
                {
                    BorderColor = Color.Red,
                    BorderRadius = 3,
                    BackgroundColor = Color.White,
                    TextColor = Color.Red,
                    Text = "X",
                    FontSize = 18,
                    HeightRequest = 35,
                    WidthRequest = 35
                }, 2, i);

            }

            for (int i = 0; i < 10; i++)
            {
                actionbtn[i].Clicked += NightPartGame_Clicked;
            }
             

            StackLayout stackLayout = new StackLayout()
            {
                Children = {  titlelabel, grid }
            };
            stackLayout.Orientation = StackOrientation.Vertical;
            stackLayout.Spacing = 8;
            stackLayout.Margin = 10;
            this.Content = stackLayout;
            this.BackgroundImage = "mafiyanithpartgame.png";
            

        }

        private void NightPartGame_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (((Button)sender) == actionbtn[i])
                {
                    actionbtn[i].BackgroundColor = Color.Black;
                    actionentry[i].BackgroundColor = Color.Black;
                    actionlbl[i].BackgroundColor = Color.Black;

                }
            }

        }

    }
}
