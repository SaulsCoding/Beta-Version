using System;
using System.Collections.Generic;
using People.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace People.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        private Order _data;
        

        public OrderPage()
        {
            InitializeComponent();
        }

        public void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            App.PersonRepo.AddNewOrder(newPerson.Text, newGender.Text, newTShirtSize.Text, newDateOfOrder.Text, newTShirt_Color.Text, newShipping_Address.Text);
            statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public void OnGetButtonClicked(object sender, EventArgs args)
        {
            
            statusMessage.Text = "";

            Navigation.PushAsync(new ViewOrderPage(_data));
        }
    }
}