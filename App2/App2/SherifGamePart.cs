using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public class SherifGamePart : ContentPage
    {
        public SherifGamePart()
        {
            Xamarin.Forms.Label titlelbl = new Xamarin.Forms.Label();
            titlelbl.Text = "Гра шерифа";
            titlelbl.HorizontalTextAlignment = TextAlignment.Center;
            titlelbl.TextColor = Color.Red;
            titlelbl.FontSize = 18;
            titlelbl.BackgroundColor = Color.White;
            titlelbl.HeightRequest = 25;
            titlelbl.WidthRequest = 150;
            titlelbl.VerticalTextAlignment = TextAlignment.Center;


            Xamarin.Forms.Grid grid = new Grid()
            {
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 400,
                HeightRequest = 500,



                RowDefinitions =
                {
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40}

                },

                ColumnDefinitions =
                {
                    new ColumnDefinition {Width =40 },
                    new ColumnDefinition {Width =40 },
                    new ColumnDefinition {Width =40 },
                    new ColumnDefinition {Width =40 },
                    new ColumnDefinition {Width =40 },
                    new ColumnDefinition {Width =40 },
                    new ColumnDefinition {Width =40 },
                    new ColumnDefinition {Width =40 },
                    new ColumnDefinition {Width =40 }

                }



            };



            grid.Children.Add(new Button//1
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "1",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 3, 0);

            grid.Children.Add(new Button//2
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "2",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 5, 0);

            grid.Children.Add(new Button//3
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "3",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 7, 1);

            grid.Children.Add(new Button//4
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "4",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 8, 3);

            grid.Children.Add(new Button//5
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "5",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 7, 5);

            grid.Children.Add(new Button//6
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "6",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 5, 6);

            grid.Children.Add(new Button//7
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "7",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 3, 6);

            grid.Children.Add(new Button//8
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "8",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 1, 5);

            grid.Children.Add(new Button//9
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "9",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 0, 3);

            grid.Children.Add(new Button//10
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "10",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 1, 1);

            grid.Children.Add(new Button//R
            {
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                Text = "R",
                FontSize = 14,
                HeightRequest = 35,
                WidthRequest = 50,

            }, 4, 3);

            StackLayout stackLayout = new StackLayout()
            {
                Children = { titlelbl, grid }
            };
            stackLayout.Orientation = StackOrientation.Vertical;
            stackLayout.Spacing = 8;
            stackLayout.Margin = 10;
            //  stackLayout.BackgroundColor = Color.Black;
            this.Content = stackLayout;
        }
    }
}
