using StringReverser.ViewModel;
using Xamarin.Forms;

namespace StringReverser
{
    public partial class StringReversePage : ContentPage
    {
        public StringReversePage()
        {
            InitializeComponent();
            BindingContext = new StringReverseViewModel(); 
        }
    }
}

