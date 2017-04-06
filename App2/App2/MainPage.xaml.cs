using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (NumberGame.Text==null )
            {
                ButtonGoToRolePage.IsEnabled = false;
                NumberGame.IsEnabled = false;
            }
        }

        
        private async void Button_ClickedGoToRolleChoosePage(object sender, EventArgs e)
        {
            
            try
            {
                Convert.ToInt32(NumberGame.Text);
                await Navigation.PushAsync(new ChooseRollesPage());
            }
            catch
            {

              await DisplayAlert("Error", "Перевірте правильність введених даних в полі номер гри", "OK", "Cancel");
             
            }

        }

      

        private void NickNameLead_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(NickNameLead.Text.Length!=0 )
            {
                NumberGame.IsEnabled = true;
            }
        }

        private void NumberGame_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NumberGame.Text.Length != 0)
            {
                ButtonGoToRolePage.IsEnabled = true;
            }
        }
    }
}
