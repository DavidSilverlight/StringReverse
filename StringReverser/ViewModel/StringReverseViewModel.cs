using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using StringReverser.CustomExtensions;

using Xamarin.Forms;

namespace StringReverser.ViewModel
{
    public class StringReverseViewModel : INotifyPropertyChanged
    {
        public StringReverseViewModel()
        {
        }

        private string _forwardText = "";
        public string ForwardText
        {
            get
            {
                return _forwardText;
            }

            set
            {
                _forwardText = value;
                RaisePropertyChanged("ReversedText");
            }
        }
         
        private string _reversedText = "";

        public event PropertyChangedEventHandler PropertyChanged;

        public string ReversedText
        {
            get
            {
                return ForwardText.ReverseByLINQ();
            }

            set
            {
                _reversedText = value;
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}