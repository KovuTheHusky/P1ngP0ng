using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace P1ngP0ng
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (File.Exists(Application.StartupPath + "\\AutoComplete.txt"))
            {
                string[] ac = File.ReadAllLines(Application.StartupPath + "\\AutoComplete.txt");
                for (int i = 0; i < ac.Length; i++)
                {
                    toolAddressCombo.AutoCompleteCustomSource.Add(ac[i]);
                    if (!toolAddressCombo.Items.Contains(ac[i]))
                        toolAddressCombo.Items.Add(ac[i]);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            Ping pingSender = new Ping();
            PingOptions pingOptions = new PingOptions();
            pingOptions.DontFragment = true;
            try
            {
                PingReply reply = pingSender.Send(toolAddressCombo.Text, Convert.ToInt32(toolIntervalCombo.Text), Encoding.ASCII.GetBytes("P1ngP0ngDataStringKoopaKoderXYZA"), pingOptions);
                if(reply.Status == IPStatus.Success)
                {
                    ListViewItem lvi = listSuccess.Items.Add(time);
                    lvi.SubItems.Add(toolAddressCombo.Text);
                    lvi.SubItems.Add(reply.RoundtripTime.ToString());
                }
                else
                {
                    ListViewItem lvi = listFailure.Items.Add(time);
                    lvi.SubItems.Add(toolAddressCombo.Text);
                    lvi.SubItems.Add(Enum.GetName(typeof(IPStatus), reply.Status));
                }
            }
            catch (Exception ex)
            {
                ListViewItem lvi = listFailure.Items.Add(time);
                lvi.SubItems.Add(toolAddressCombo.Text);
                lvi.SubItems.Add("Exception");
                lvi.ToolTipText = ex.Message;
            }
        }

        private void toolStart_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Interval = Convert.ToInt32(toolIntervalCombo.Text);
            }
            catch (Exception)
            {
                toolIntervalCombo.Text = "1000";
                timer.Interval = Convert.ToInt32(toolIntervalCombo.Text);
            }
            if(toolAddressCombo.Text.Length >= 7) if(toolAddressCombo.Text.Substring(0, 7) == "http://") toolAddressCombo.Text = toolAddressCombo.Text.Remove(0, 7);
            timer.Enabled = true;
            toolStart.Enabled = false;
            toolStop.Enabled = true;
            toolAddressCombo.Enabled = false;
            toolIntervalCombo.Enabled = false;
            toolAddressCombo.Items.Add(toolAddressCombo.Text);
            toolIntervalCombo.Items.Add(toolIntervalCombo.Text);
            if (File.Exists(Application.StartupPath + "\\AutoComplete.txt"))
            {
                string[] ac = File.ReadAllLines(Application.StartupPath + "\\AutoComplete.txt");
                string[] ac2 = new string[ac.Length + 1];
                for (int i = 0; i < ac.Length; i++)
                {
                    ac2[i] = ac[i];
                }
                ac2[ac.Length] = toolAddressCombo.Text;
                File.WriteAllLines(Application.StartupPath + "\\AutoComplete.txt", ac2);
            }
            else
            {
                string[] ac = new string[1];
                ac[0] = toolAddressCombo.Text;
                File.WriteAllLines(Application.StartupPath + "\\AutoComplete.txt", ac);
            }
        }

        private void toolStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            toolStart.Enabled = true;
            toolStop.Enabled = false;
            toolAddressCombo.Enabled = true;
            toolIntervalCombo.Enabled = true;
        }

        private void clearAllHistory_Click(object sender, EventArgs e)
        {
            clearSuccessHistory.PerformClick();
            clearFailureHistory.PerformClick();
        }

        private void clearSuccessHistory_Click(object sender, EventArgs e)
        {
            listSuccess.Items.Clear();
        }

        private void clearFailureHistory_Click(object sender, EventArgs e)
        {
            listFailure.Items.Clear();
        }

        private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.huskehlabs.com/");
        }

        private void labelEasterEgg_Click(object sender, EventArgs e)
        {
            pictureEasterEgg.Visible = true;
        }

        private void listFailure_DoubleClick(object sender, EventArgs e)
        {
            if (listFailure.SelectedItems[0].ToolTipText != "")
            {
                MessageBox.Show(listFailure.SelectedItems[0].ToolTipText);
            }
        }

        private void Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) toolStart.PerformClick();
        }

        private void Interval_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) toolStart.PerformClick();
        }

        private void Failure_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (listFailure.SelectedItems[0].ToolTipText != "")
                    {
                        MessageBox.Show(listFailure.SelectedItems[0].ToolTipText);
                    }
                }
                else if (e.KeyData == Keys.Delete)
                {
                    listFailure.Items.Remove(listFailure.SelectedItems[0]);
                }
            }
            catch
            {
            }
        }

        private void Success_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Delete)
                {
                    listSuccess.Items.Remove(listSuccess.SelectedItems[0]);
                }
            }
            catch
            {
            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            saveFile.FileName = "";
            saveFile.ShowDialog();
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            string success = "";
            for (int i = 0; i < listSuccess.Items.Count; i++)
            {
                success += listSuccess.Items[i].SubItems[0].Text + "\t" + listSuccess.Items[i].SubItems[1].Text + "\t" + listSuccess.Items[i].SubItems[2].Text +"\r\n";
            }
            string failure = "";
            for (int i = 0; i < listFailure.Items.Count; i++)
            {
                failure += listFailure.Items[i].SubItems[0].Text + "\t" + listFailure.Items[i].SubItems[1].Text + "\t" + listFailure.Items[i].SubItems[2].Text + "\r\n";
            }
            File.WriteAllText(saveFile.FileName, "Success:\r\n\r\n" + success + "\r\n\r\nFailure:\r\n\r\n" + failure);
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
