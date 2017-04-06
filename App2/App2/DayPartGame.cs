using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public class DayPartGame : ContentPage
    {
        bool alive = true;
        
        Xamarin.Forms.Button btn = new Button();
        Xamarin.Forms.Picker picker1 = new Picker();
        Xamarin.Forms.Switch swichtimer = new Switch();
        Xamarin.Forms.Label timerlbl = new Xamarin.Forms.Label();
        Xamarin.Forms.Label switchlbl = new Xamarin.Forms.Label();
        Xamarin.Forms.Button goBtn = new Button();
        Xamarin.Forms.Button stopBtn = new Button();
        Xamarin.Forms.Button pauseBtn = new Button();
        Xamarin.Forms.Button nullBtn = new Button();
        public DayPartGame()
        {
           

            Xamarin.Forms.Label titlelabel = new Xamarin.Forms.Label();
            titlelabel.Text = "День";
            titlelabel.HorizontalTextAlignment = TextAlignment.Center;
            titlelabel.TextColor = Color.Red;
            titlelabel.FontSize = 18;
            titlelabel.BackgroundColor = Color.White;
            titlelabel.HeightRequest = 25;
            titlelabel.WidthRequest = 150;
            titlelabel.VerticalTextAlignment = TextAlignment.Center;

            Xamarin.Forms.Grid timergrid = new Grid()
            {
                VerticalOptions = LayoutOptions.Fill,

                RowDefinitions =
                {
                    new RowDefinition { Height = 35}

                },

                ColumnDefinitions =
                {
                    new ColumnDefinition {Width =50 },
                    new ColumnDefinition {Width = 50  },
                    new ColumnDefinition {Width = 100  },
                    new ColumnDefinition {Width = 30},
                    new ColumnDefinition {Width = 30},
                    new ColumnDefinition {Width = 30},
                    new ColumnDefinition {Width = 30}

                }


            };
          //  Device.StartTimer(TimeSpan interval, Func < bool > callback);
            timergrid.Children.Add( swichtimer= new Switch  {
                IsToggled = true,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            },0,0);

            
            timergrid.Children.Add(switchlbl= new Label
            {
                VerticalTextAlignment = TextAlignment.Start,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                FontSize = 14,
                Text = "1 хв",
                HeightRequest = 35,
                WidthRequest = 50
            },1,0);

            timergrid.Children.Add(timerlbl= new Label
            {
                VerticalTextAlignment = TextAlignment.Start,
                BackgroundColor = Color.White,
                TextColor = Color.Red,
                FontSize = 14,
                Text = "",
                HeightRequest = 35,
                WidthRequest = 50
            }, 2, 0);

            timergrid.Children.Add( goBtn = new Button {
                Text = "G",
                TextColor = Color.Black,
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                WidthRequest = 25     
            },3,0);

            timergrid.Children.Add(stopBtn = new Button
            {
                Text = "S",
                TextColor = Color.Black,
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                WidthRequest = 25
            }, 4, 0);

            timergrid.Children.Add(pauseBtn = new Button
            {
                Text = "P",
                TextColor = Color.Black,
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                WidthRequest = 25
            }, 5, 0);

            timergrid.Children.Add(nullBtn = new Button
            {
                Text = "N",
                TextColor = Color.Black,
                BorderColor = Color.Red,
                BorderRadius = 20,
                BackgroundColor = Color.White,
                WidthRequest = 25
            }, 6, 0);




            Xamarin.Forms.Grid grid = new Grid()
            {
                VerticalOptions = LayoutOptions.Fill,

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
                    new ColumnDefinition {Width = 100  },
                    new ColumnDefinition {Width = 80  },


                }



            };


            for (int i = 0; i < 10; i++)
            {
                grid.Children.Add(new Xamarin.Forms.Label
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
                grid.Children.Add(new Entry
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
                grid.Children.Add(new Xamarin.Forms.Label
                {
                    BackgroundColor = Color.White,
                    TextColor = Color.Red,
                    HeightRequest = 25,
                    WidthRequest = 70,
                    Text = i.ToString() + " фол"
                }, 2, i);

            }

            for (int i = 0; i < 10; i++)
            {
                grid.Children.Add(btn = new Button
                {
                    BorderColor = Color.Red,
                    BorderRadius = 3,
                    BackgroundColor = Color.White,
                    TextColor = Color.Red,
                    Text = "Action",
                    FontSize = 14,
                    HeightRequest = 35,
                    WidthRequest = 50,


                }, 3, i);

            }

            swichtimer.Toggled += Swichtimer_Toggled;
            goBtn.Clicked += GoBtn_Clicked;
            pauseBtn.Clicked += PauseBtn_Clicked;
            stopBtn.Clicked += StopBtn_Clicked;
            nullBtn.Clicked += NullBtn_Clicked;

            StackLayout stackLayout = new StackLayout()
            {
                Children = {timergrid, titlelabel, grid }
            };
            stackLayout.Orientation = StackOrientation.Vertical;
            stackLayout.Spacing = 8;
            stackLayout.Margin = 10;
            this.Content = stackLayout;
        }

      
        private void NullBtn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StopBtn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PauseBtn_Clicked(object sender, EventArgs e)
        {
           
        }

        

        private void GoBtn_Clicked(object sender, EventArgs e)
        {
            
            TimeSpan startspan = new TimeSpan(0,1,0);
            TimeSpan span2 = TimeSpan.FromSeconds(1);
            TimeSpan span3 ;

            // could also write `now - otherTime`
            for (int i =0; i<54;i++)
            {
                span3 = startspan.Subtract(span2);
                startspan = span3;
                timerlbl.Text = span3.ToString();

            }
            
            //Device.StartTimer(TimeSpan.FromSeconds(60), OnTimerTick);
        }

        

        private bool OnTimerTick()
        {
            timerlbl.Text = "0:" + "01:" + "00";
          
            return alive;
        }
        private void Swichtimer_Toggled(object sender, ToggledEventArgs e)
        {
            bool isTogged = e.Value;
            string tmr="1 хв";
            
            if (isTogged == true)
            {
                tmr = "1 хв";
            }
            else
            {
                tmr = "30 сек";
            }
            switchlbl.Text = String.Format( tmr);
            
        }

        private async void ActionMenu(object sender, EventArgs e)
        {


            string doaction = await DisplayActionSheet(null, "Cancel", null,
                                                        "Фол",
                                                        "На голосування",
                                                        "Видалення",
                                                        "Дискваліфікація");

            if (doaction == "Фол")
            {
                btn.Text += "1_Фол";
            };
            if (doaction == "На голосування")
            {
                btn.Text = "1_Фол";
            }

        }
    }
}
