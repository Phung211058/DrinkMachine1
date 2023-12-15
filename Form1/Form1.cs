using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinkMachineLibrary;



namespace Form1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void btn_ok_Click(object sender, EventArgs e)
        //{

        //}

        //private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        //{

        //}

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            if (!rad_water.Checked && !rad_orange.Checked && !rad_mango.Checked)
            {
                lbl_announce.Text = "Please choose your option!";
            }
            else
            {
                lbl_announce.Text = "Wait a few minutes";
                DrinkMachine may = new DrinkMachine();
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    may.MakeWatermelonSmoothie1();
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    may.MakeWatermelonJuice();
                }
                else if (rad_orange.Checked && rad_smoothie.Checked)
                {
                    may.MakeOrangeSmoothie();
                }
                else if (rad_orange.Checked && rad_juice.Checked)
                {
                    may.MakeOrangeJuice();
                }
            }
        }
           
    }
}
