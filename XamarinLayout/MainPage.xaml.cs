using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinLayout
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void VaiParaStack(object o, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }
        private void VaiParaGrid(object o, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }
        private void VaiParaAbsolute(object o, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }
        private void VaiParaRelative(object o, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }
        private void VaiParaScroll(object o, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
    }
}
