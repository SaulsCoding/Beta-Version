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

        public ViewOrderPage()
        {
            InitializeComponent();

           // Title = "Order List";

            //BindingContext = _data;
        }
    }
}