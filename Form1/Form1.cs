using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinkMachineLibrary;



namespace Form1
{
    public partial class Form1 : Form
    {
        //private bool isWorker1Running = false;
        //private bool isWorker2Running = false;
        //private bool isWorker3Running = false;
        //private bool isWorker4Running = false;
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
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    Thread.Sleep(30);
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    Thread.Sleep(120);
                }
                sum += i;
                backgroundWorker1.ReportProgress(i);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            e.Result = sum;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgress_cutter.Value = e.ProgressPercentage;
            lbl_percent_cutter.Text = e.ProgressPercentage.ToString() + "%";

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbl_announce.Text = "Progress has been cancelled";
            }
            else if (e.Error != null)
            {
                lbl_announce.Text = e.Error.Message;
            }
            else
            {
                //isWorker1Running = false;
                //lbl_announce.Text = "Successfully";
                //isWorker2Running = true;
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            if (!rad_water.Checked && !rad_orange.Checked && !rad_mango.Checked) 
            {
                lbl_announce.Text = "Please choose your option!";
            }
            //else if ((rad_water.Checked || rad_orange.Checked || rad_mango.Checked) && (rad_juice.Checked || rad_smoothie.Checked))
            else
            {
                lbl_announce.Text = "Wait a few minutes, please!";
                DrinkMachine may = new DrinkMachine();
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    may.MakeWatermelonSmoothie1();
                    backgroundWorker1.RunWorkerAsync();
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    may.MakeWatermelonJuice();
                    backgroundWorker1.RunWorkerAsync();
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

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    Thread.Sleep(30);
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    Thread.Sleep(120);
                }
                sum += i;
                backgroundWorker2.ReportProgress(i);
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker2.ReportProgress(0);
                    return;
                }
            }
            e.Result = sum;
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgress_blender.Value = e.ProgressPercentage;
            lbl_percent_blender.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbl_announce.Text = "Progress has been cancelled";
            }
            else if (e.Error != null)
            {
                lbl_announce.Text = e.Error.Message;
            }
            else
            {
                backgroundWorker3.RunWorkerAsync();
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    Thread.Sleep(30);
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    Thread.Sleep(120);
                }
                sum += i;
                backgroundWorker3.ReportProgress(i);
                if (backgroundWorker3.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker3.ReportProgress(0);
                    return;
                }
            }
            e.Result = sum;
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgress_cleanser.Value = e.ProgressPercentage;
            lbl_percent_cleanser.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbl_announce.Text = "Progress has been cancelled";
            }
            else if (e.Error != null)
            {
                lbl_announce.Text = e.Error.Message;
            }
            else
            {
                backgroundWorker4.RunWorkerAsync();
            }
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    Thread.Sleep(30);
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    Thread.Sleep(120);
                }
                sum += i;
                backgroundWorker4.ReportProgress(i);
                if (backgroundWorker4.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker4.ReportProgress(0);
                    return;
                }
            }
            e.Result = sum;
        }

        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgress_presser.Value = e.ProgressPercentage;
            lbl_percent_presser.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbl_announce.Text = "Progress has been cancelled";
            }
            else if (e.Error != null)
            {
                lbl_announce.Text = e.Error.Message;
            }
            else
            {
                backgroundWorker5.RunWorkerAsync();
            }
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    Thread.Sleep(30);
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    Thread.Sleep(120);
                }
                sum += i;
                backgroundWorker5.ReportProgress(i);
                if (backgroundWorker5.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker5.ReportProgress(0);
                    return;
                }
            }
            e.Result = sum;
        }

        private void backgroundWorker5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgress_filter.Value = e.ProgressPercentage;
            lbl_percent_filter.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbl_announce.Text = "Progress has been cancelled";
            }
            else if (e.Error != null)
            {
                lbl_announce.Text = e.Error.Message;
            }
            else
            {
                lbl_announce.Text = "Successfully";
            }
        }
    }
}
