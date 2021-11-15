using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace infoAppGUI
{
    class DialWindow : Window
    {
        //[UI] private Label _label1 = null;
        [UI] private Button buttonClose = null;

        public DialWindow() : this(new Builder("DialWindow.glade")) { }

        private DialWindow(Builder builder) : base(builder.GetRawOwnedObject("winDialogue"))
        {
            builder.Autoconnect(this);

            //DeleteEvent += Window_DeleteEvent;
            buttonClose.Clicked += buttonClose_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void buttonClose_Clicked(object sender, EventArgs a)
        {
            /*_counter++;
            _label1.Text = "Hello World! This button has been clicked " + _counter + " time(s).";*/

            Console.WriteLine("Systeme d'exploitation et version : " + Environment.OSVersion);
            Console.WriteLine("Connecté en tant que : " + Environment.UserName);
            this.Close();
        }
    }
}
