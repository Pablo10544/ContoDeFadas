
using CommunityToolkit.Mvvm.ComponentModel;
using DesignClassMAUIChallenge6.Resources.Model;
using Microsoft.Maui.Handlers;

namespace DesignClassMAUIChallenge6
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            ModifySearchBar();
            BindingContext = new ContoDeFadasViewModel();
        }



        private void ModifySearchBar()
        {
        }
    }

}
