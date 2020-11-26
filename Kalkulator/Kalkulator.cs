using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        double labelVAL1 = 0;
        double labelVAL2 = 0;
        double summ = 0;
        string status = "";

        public Kalkulator()
        {
            InitializeComponent();
            LABEL.Text = "0";
        }
        void clearLABEL()
        {
            LABEL.Text = "";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            
            labelVAL2 = Convert.ToDouble(LABEL.Text);
            if (status == "PLUS")
            {
                summ = labelVAL1 + labelVAL2;
                clearLABEL();
                LABEL.Text = summ.ToString();
                status = "";
                
                labelVAL1 = 0;
                labelVAL2 = 0;
            }else if(status == "MINUS")
            {
                summ = labelVAL1 - labelVAL2;
                clearLABEL();
                LABEL.Text = summ.ToString();
                status = "";

                labelVAL1 = 0;
                labelVAL2 = 0;
            }
            else if (status == "MULTI")
            {
                summ = labelVAL1 * labelVAL2;
                clearLABEL();
                LABEL.Text = summ.ToString();
                status = "";

                labelVAL1 = 0;
                labelVAL2 = 0;
            }
            else if (status == "DIVIDE")
            {
                summ = labelVAL1 / labelVAL2;
                clearLABEL();
                LABEL.Text = summ.ToString();
                status = "";

                labelVAL1 = 0;
                labelVAL2 = 0;
            }

        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            if(LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                summ = 0;
                LABEL.Text = LABEL.Text + "1";
            }
            else
            {
                LABEL.Text = LABEL.Text + "1";
            }
            
            

        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            if (LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                LABEL.Text = LABEL.Text + "2";
            }
            else
            {
                LABEL.Text = LABEL.Text + "2";
            }
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            if (LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                LABEL.Text = LABEL.Text + "3";
            }
            else
            {
                LABEL.Text = LABEL.Text + "3";
            }
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            if (LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                LABEL.Text = LABEL.Text + "4";
            }
            else
            {
                LABEL.Text = LABEL.Text + "4";
            }
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            if (LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                LABEL.Text = LABEL.Text + "5";
            }
            else
            {
                LABEL.Text = LABEL.Text + "5";
            }
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            if (LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                LABEL.Text = LABEL.Text + "6";
            }
            else
            {
                LABEL.Text = LABEL.Text + "6";
            }
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            if (LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                LABEL.Text = LABEL.Text + "7";
            }
            else
            {
                LABEL.Text = LABEL.Text + "7";
            }
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            if (LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                LABEL.Text = LABEL.Text + "8";
            }
            else
            {
                LABEL.Text = LABEL.Text + "8";
            }
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            if (LABEL.Text == "0" || LABEL.Text == summ.ToString())
            {
                clearLABEL();
                LABEL.Text = LABEL.Text + "9";
            }
            else
            {
                LABEL.Text = LABEL.Text + "9";
            }
        }

        private void BTNplus_Click(object sender, EventArgs e)
        {
            labelVAL1 = Convert.ToDouble(LABEL.Text);
            status = "PLUS";
            clearLABEL();
        }

        private void BTNminus_Click(object sender, EventArgs e)
        {
            labelVAL1 = Convert.ToDouble(LABEL.Text);
            status = "MINUS";
            
            clearLABEL();
        }

        private void BTNmulti_Click(object sender, EventArgs e)
        {
            labelVAL1 = Convert.ToDouble(LABEL.Text);
            status = "MULTI";
            
            clearLABEL();
        }
        

        private void BTNdiv_Click(object sender, EventArgs e)
        {
            labelVAL1 = Convert.ToDouble(LABEL.Text);
            status = "DIVIDE";
            clearLABEL();
        }

        private void BTNreset_Click(object sender, EventArgs e)
        {
            clearLABEL();
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            LABEL.Text = LABEL.Text + "0";
        }

        private void LABEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
