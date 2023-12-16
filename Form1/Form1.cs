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
        private Cleanser cleanser = new Cleanser();
        private Cutter cutter = new Cutter();
        private Blender blender = new Blender();
        private Presser presser = new Presser();
        private Filter filter = new Filter();
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
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(80);
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    sum = cleanser.Clean(true, 400);
                    backgroundWorker1.ReportProgress(sum);
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    sum = cleanser.Clean(true, 400);
                    backgroundWorker1.ReportProgress(sum);
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_orange.Checked && rad_juice.Checked)
                {
                    sum = cleanser.Clean(true, 200);
                    backgroundWorker1.ReportProgress(sum);
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_orange.Checked && rad_smoothie.Checked)
                {
                    sum = cleanser.Clean(true, 200);
                    backgroundWorker1.ReportProgress(sum);
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_mango.Checked && rad_smoothie.Checked)
                {
                    sum = cleanser.Clean(true, 400);
                    backgroundWorker1.ReportProgress(sum);
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_mango.Checked && rad_juice.Checked)
                {
                    sum = cleanser.Clean(true, 400);
                    backgroundWorker1.ReportProgress(sum);
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
                //sum = i;

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
                if(!rad_juice.Checked && !rad_smoothie.Checked)
                {
                    lbl_announce.ForeColor = Color.Red;
                    lbl_announce.Text = "Please choose your option!";

                }
            }
            else if ((rad_water.Checked || rad_orange.Checked || rad_mango.Checked) && (rad_juice.Checked || rad_smoothie.Checked))
            //else
            {
                lbl_announce.ForeColor = Color.Blue;
                lbl_announce.Text = "Wait a few minutes, please!";
                DrinkMachine may = new DrinkMachine();
                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    may.MakeWatermelonSmoothie();
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
                    backgroundWorker1.RunWorkerAsync();

                }
                else if (rad_orange.Checked && rad_juice.Checked)
                {
                    may.MakeOrangeJuice();
                    backgroundWorker1.RunWorkerAsync();
                }
                else if (rad_mango.Checked && rad_juice.Checked)
                {
                    may.MakeOrangeJuice();
                    backgroundWorker1.RunWorkerAsync();
                }
                else if (rad_mango.Checked && rad_smoothie.Checked)
                {
                    may.MakeOrangeJuice();
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(80);

                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    sum = cutter.Cut(2);
                    backgroundWorker2.ReportProgress(sum);
                    if (backgroundWorker2.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker2.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_water.Checked && rad_juice.Checked)
                {
                    sum = cutter.Cut(2);
                    backgroundWorker2.ReportProgress(sum);
                    if (backgroundWorker2.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker2.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_orange.Checked && rad_juice.Checked)
                {
                    sum = cutter.Cut(1);
                    backgroundWorker2.ReportProgress(sum);
                    if (backgroundWorker2.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker2.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_orange.Checked && rad_smoothie.Checked)
                {
                    sum = cutter.Cut(1);
                    backgroundWorker2.ReportProgress(sum);
                    if (backgroundWorker2.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker2.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_mango.Checked && rad_juice.Checked)
                {
                    sum = cutter.Cut(3);
                    backgroundWorker2.ReportProgress(sum);
                    if (backgroundWorker2.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker2.ReportProgress(0);
                        return;
                    }
                }
                else if (rad_mango.Checked && rad_smoothie.Checked)
                {
                    sum = cutter.Cut(3);
                    backgroundWorker2.ReportProgress(sum);
                    if (backgroundWorker2.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker2.ReportProgress(0);
                        return;
                    }
                }
                //sum += i;

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
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(80);

                if (rad_water.Checked && rad_smoothie.Checked)
                {
                    sum = blender.Puree(2);
                    backgroundWorker3.ReportProgress(sum);
                    if (backgroundWorker3.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker3.ReportProgress(0);
                        return;
                    }
                }
                if (rad_orange.Checked && rad_smoothie.Checked)
                {
                    sum = blender.Puree(1);
                    backgroundWorker3.ReportProgress(sum);
                    if (backgroundWorker3.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker3.ReportProgress(0);
                        return;
                    }
                }
                if (rad_mango.Checked && rad_smoothie.Checked)
                {
                    sum = blender.Puree(3);
                    backgroundWorker3.ReportProgress(sum);
                    if (backgroundWorker3.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker3.ReportProgress(0);
                        return;
                    }
                }
                //sum += i;

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
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(80);

               
                if (rad_water.Checked && rad_juice.Checked)
                {
                    sum = presser.Press(2);
                    backgroundWorker4.ReportProgress(sum);
                    if (backgroundWorker4.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker4.ReportProgress(0);
                        return;
                    }
                }
                if (rad_orange.Checked && rad_juice.Checked)
                {
                    sum = presser.Press(1);
                    backgroundWorker4.ReportProgress(sum);
                    if (backgroundWorker4.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker4.ReportProgress(0);
                        return;
                    }
                }
                if (rad_mango.Checked && rad_juice.Checked)
                {
                    sum = presser.Press(1);
                    backgroundWorker4.ReportProgress(sum);
                    if (backgroundWorker4.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker4.ReportProgress(0);
                        return;
                    }
                }
                //sum += i;

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
            for (int i = 0; i <= 10; i++)
            {
                    Thread.Sleep(80);

                if (rad_water.Checked && rad_juice.Checked)
                {
                    sum = filter.Filt(2);
                    backgroundWorker5.ReportProgress(sum);
                    if (backgroundWorker5.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker5.ReportProgress(0);
                        return;
                    }
                }
                if (rad_orange.Checked && rad_juice.Checked)
                {
                    sum = filter.Filt(1);
                    backgroundWorker5.ReportProgress(sum);
                    if (backgroundWorker5.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker5.ReportProgress(0);
                        return;
                    }
                }
                if (rad_mango.Checked && rad_juice.Checked)
                {
                    sum = filter.Filt(3);
                    backgroundWorker5.ReportProgress(sum);
                    if (backgroundWorker5.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker5.ReportProgress(0);
                        return;
                    }
                }
                //sum += i;

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
                lbl_announce.ForeColor = Color.Green;
                if (rad_juice.Checked && rad_water.Checked)
                {
                    lbl_announce.Text = "Waterlemon juice successfully";
                }
                if (rad_juice.Checked && rad_orange.Checked)
                {
                    lbl_announce.Text = "Orange juice successfully";
                }
                if (rad_juice.Checked && rad_mango.Checked)
                {
                    lbl_announce.Text = "Mango juice successfully";
                }
                if (rad_smoothie.Checked && rad_water.Checked)
                {
                    lbl_announce.Text = "Waterlemon smoothie successfully";
                }
                if (rad_smoothie.Checked && rad_orange.Checked)
                {
                    lbl_announce.Text = "Orange smoothie successfully";
                }
                if (rad_smoothie.Checked && rad_mango.Checked)
                {
                    lbl_announce.Text = "Mango smoothie successfully";
                }

            }
        }

        private void rad_water_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
