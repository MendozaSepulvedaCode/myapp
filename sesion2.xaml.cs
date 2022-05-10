using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sesion2 : ContentPage
    {
        public sesion2(String n, String a, String c)
        {
            InitializeComponent();
        }
    }
}