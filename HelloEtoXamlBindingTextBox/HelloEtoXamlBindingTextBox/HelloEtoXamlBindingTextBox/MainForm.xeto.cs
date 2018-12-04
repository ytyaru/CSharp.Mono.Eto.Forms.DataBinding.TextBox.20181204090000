using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;
using Eto.Serialization.Xaml;

namespace HelloEtoXamlBindingTextBox
{
    public class MainForm : Form
    {
        public MainForm()
        {
            XamlReader.Load(this);
            var model = new UrlModel();
            DataContext = model;
        }
    }
}
