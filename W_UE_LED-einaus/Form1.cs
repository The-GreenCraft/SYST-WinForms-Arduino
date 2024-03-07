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
            Wert_senden(1);
        }

        private void Wert_senden(byte[] bytArrSenden)
        {

        }
    }
}
