using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallpaper_forms.Services
{
    public static class MessageBoxService
    {
        public static void Show(string message)
        {

            // Initializes the variables to pass to the MessageBox.Show method.
            string caption = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;



            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons);
        }

    }
}
