using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Owin.Hosting;
using SecondKeyboard.Controllers;
using Microsoft.VisualBasic.Devices;

namespace SecondKeyboard.Win
{
    public partial class Form1 : Form, IKeySender
    {
        private IDisposable _app;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string baseAddress = "http://*:9000/";

            _app = WebApp.Start<Startup>(url: baseAddress);
            KeyboardController.KeySender = this;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _app.Dispose();
        }

        public void Send(string value, bool ctrl = false, bool shift = false, bool alt = false)
        {
            if(InvokeRequired)
            {
                Action<string, bool, bool, bool> d = new Action<string, bool, bool, bool>(Send);
                Invoke(d, value, ctrl, shift, alt);
                return;
            }

            if (ctrl) value = "^" + value;
            if (shift) value = "+" + value;
            if (alt) value = "%" + value;

            Keyboard kb = new Keyboard();
            kb.SendKeys(value);
        }
    }
}
