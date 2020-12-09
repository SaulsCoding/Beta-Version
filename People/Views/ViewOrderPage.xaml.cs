using People.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace People.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewOrderPage : ContentPage
    {

        public ViewOrderPage(Order _data)
        {
            InitializeComponent();

           Title = "Order List";
            List<Order> tshirtorder = App.OrderRepo.GetAllOrder();
            orderList.ItemsSource = tshirtorder;
            BindingContext = _data;
        }
    }
}