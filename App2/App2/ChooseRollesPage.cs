using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public class ChooseRollesPage : ContentPage
    {
        public List<Player> player = new List<Player>(10);
        List<string> Rolles = new List<string>() { "Мафія","Дон","Шериф","Мирний"};
        Xamarin.Forms.Button gotogame = new Button();
        public Xamarin.Forms.Label[] choosrollespglbl = new Xamarin.Forms.Label[10];
        public Entry[] choosrollespgentry = new Entry[10];
        public Picker[] choosrollespgpicker = new Picker[10];
        
       
        public ChooseRollesPage()
        {

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
                    new ColumnDefinition {Width = 200  },
                    new ColumnDefinition {Width = 150  }


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
                    TextColor = Color.Black,
                    FontSize = 14,
                    FontAttributes = FontAttributes.Bold,
                    HorizontalTextAlignment = TextAlignment.Start,
                    Placeholder = "Player_" + (i + 1).ToString(),
                    PlaceholderColor = Color.Red

                }, 1, i);

            }
   


            for (int i = 0; i < 10; i++)
            {
                grid.Children.Add(choosrollespgpicker[i] = new Xamarin.Forms.Picker
                {
                    BackgroundColor = Color.White,
                    TextColor = Color.Red,
                    HeightRequest = 25,
                    WidthRequest = 140
                }, 2, i);

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j=0; j < 4; j++)
                {
                    choosrollespgpicker[i].Items.Add(Rolles[j].ToString());
                }

                choosrollespgpicker[i].SelectedIndexChanged += ChooseRollesPage_SelectedIndexChanged;
            }

        
            gotogame.BackgroundColor = Color.White;
            gotogame.WidthRequest = 30;
            gotogame.HeightRequest = 30;
            gotogame.Text = "ВПЕРЕД";
            gotogame.Clicked += Gotogame_Clicked;
            gotogame.TextColor = Color.Red;
            gotogame.BorderRadius = 10;
            gotogame.BorderColor = Color.Black;
            gotogame.FontSize = 14;
            

            StackLayout stackLayout = new StackLayout()
            {
                Children = {  grid, gotogame }
            };
            stackLayout.Orientation = StackOrientation.Vertical;
            stackLayout.Spacing = 8;
            stackLayout.Margin = 10;
            this.Content = stackLayout;
            this.BackgroundImage = "SaluteLMC.png";
        }
        
        private void ChooseRollesPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int mafcounter = 0;
            // pickervalue = choosrollespgpicker[2].Items[choosrollespgpicker[2].SelectedIndex];

                       
                for (int i = 0; i < choosrollespgpicker.Length; i++)
                {
                    if (choosrollespgpicker[i].SelectedIndex == 1)
                    {
                      for (int j = i+1; j < choosrollespgpicker.Length; j++)
                      {
                          choosrollespgpicker[j].Items.Remove("Дон");
                      }
                    }


                  if (choosrollespgpicker[i].SelectedIndex == 2)
                  {
                          for (int j = i + 1; j < choosrollespgpicker.Length-i; j++)
                          {
                              choosrollespgpicker[j].Items.Remove("Шериф");
                          }
                  }



                  if (choosrollespgpicker[i].SelectedIndex == 0)
                  {
                      mafcounter++;

                      if(mafcounter == 2)
                      {
                          for (int j = i + 1; j < choosrollespgpicker.Length; j++)
                          {
                          choosrollespgpicker[j].Items.Remove("Мафія");
                          }
                      }

                  }

                
              
                    
                 
          
                
                }

               
        }
        private async void Gotogame_Clicked(object sender, EventArgs e)
        {
           
            
            await Navigation.PushAsync(new GameProcess());
        }
    
    }
}
