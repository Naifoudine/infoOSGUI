using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace infoAppGUI
{
    class MainWindow : Window
    {
        [UI] private Label _label1 = null;
        [UI] private Button _button1 = null;

        private int _counter;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _button1.Clicked += Button1_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void Button1_Clicked(object sender, EventArgs a)
        {
            _label1.Text = "Systeme d'exploitation et version : " + Environment.OSVersion +"\n";
            _label1.Text += "Connecté en tant que : " + Environment.UserName;

            /*DialWindow win = new DialWindow();
            win.Show();*/
        }
    }
}
