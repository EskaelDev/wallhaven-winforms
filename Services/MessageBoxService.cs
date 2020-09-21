using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallpaper_forms.Services
{
    public class MessageBoxService : IMessageBoxService
    {
        private readonly ILogger<RequestService> _log;
        private readonly IConfiguration _config;

        public MessageBoxService(ILogger<RequestService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public void Show(string message)
        {

            // Initializes the variables to pass to the MessageBox.Show method.
            string caption = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            //DialogResult result;

            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons);
        }

    }
}
