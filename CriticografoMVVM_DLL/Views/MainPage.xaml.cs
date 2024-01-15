using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriticografoMVVM_DLL.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CriticografoMVVM_DLL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM(Navigation);
        }
    }
}