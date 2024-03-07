using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_UE_LED_einaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_on_Click(object sender, EventArgs e)
        {
            LED_On();
        }
        private void LED_On()
        {
            byte[] bytArrSenden = new byte[1];

            bytArrSenden[0] = 1;
            Wert_senden(bytArrSenden);
        }

        private void Wert_senden(byte[] bytArrSenden)
        {
            Port_Open();
            Senden(bytArrSenden);
            Port_Close();
        }

        private void Port_Open()
        {
            serialPortLED.Open();
        }
        private void Port_Close()
        {
            serialPortLED.Close();
        }
    }
}
