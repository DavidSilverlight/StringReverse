using System;
using System.Collections.Generic;
using StringReverser.Helpers;
using Xamarin.Forms;
using System.Linq;

namespace StringReverser
{
    public partial class StringReversePageQuick : ContentPage
    {
        public StringReversePageQuick()
        {
            InitializeComponent();
        } 

        void TextForwardString_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            try
            {
                string inputText = ((Entry)sender).Text;
                labelTextReverse.Text = ReverseByLINQ(inputText);
            }
            catch (Exception exc)
            {
                ExceptionHelper.ProcessException(exc);
            }
        }

        public static string ReverseByLINQ(String inputString)
        {

            var reversedString = "";

            try
            {
                reversedString = new string(inputString.ToCharArray().Reverse().ToArray());
            }
            catch (Exception exc)
            {
                reversedString = "";
                ExceptionHelper.ProcessException(exc);
            }
            return reversedString;

        }
    }
}

