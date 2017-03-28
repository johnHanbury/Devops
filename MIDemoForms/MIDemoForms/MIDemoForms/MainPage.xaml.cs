using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MIDemoForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Image.Source = ImageSource.FromUri(new Uri("https://www.marine.ie/Home/sites/default/files/MIFiles/Images/General/Marine_logo.jpg"));
        }
    }
}
