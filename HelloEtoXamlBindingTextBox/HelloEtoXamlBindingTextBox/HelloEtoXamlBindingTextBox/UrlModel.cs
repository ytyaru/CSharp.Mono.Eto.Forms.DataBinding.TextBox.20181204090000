﻿﻿using System;
using System.ComponentModel; // INotifyPropertyChanged
using System.Runtime.CompilerServices; // CallerMemberName

namespace HelloEtoXamlBindingTextBox
{
    public class UrlModel : INotifyPropertyChanged
    {
        String url;
        public String Url { get { return url; } set { this.url = value; OnPropertyChanged(); } }      
        void OnPropertyChanged([CallerMemberName] string memberName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}