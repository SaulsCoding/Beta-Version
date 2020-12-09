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

        public void AddBtn(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            App.OrderRepo.AddNewOrder(newName.Text, newGender.Text, newTShirtSize.Text, newDateOfOrder.Text, newTShirt_Color.Text, newShipping_Address.Text);
            statusMessage.Text = App.OrderRepo.StatusMessage;
        }

        public void GetBtn(object sender, EventArgs args)
        {
            
            statusMessage.Text = "";

            Navigation.PushAsync(new ViewOrderPage(_data));
        }
    }
}