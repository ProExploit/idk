using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;
namespace Syn_Ware
{
    public partial class Form1 : Form
    {
        EasyExploits.Module module = new Module();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage();
            FastColoredTextBoxNS.FastColoredTextBox textBox = new FastColoredTextBoxNS.FastColoredTextBox();
            newTab.Name = "Script" + (visualStudioTabControl1.TabCount + 1);
            newTab.Text = "New Tab  ";
            newTab.Parent = visualStudioTabControl1;
            textBox.Dock = DockStyle.Fill;
            textBox.Name = "fastColoredTextBox1";
            textBox.BackColor = Color.FromArgb(8, 8, 8);
            textBox.LineNumberColor = Color.White;
            textBox.ServiceLinesColor = Color.FromArgb(5, 5, 5);
            textBox.IndentBackColor = Color.FromArgb(5, 5, 5);
            textBox.Parent = newTab;
            visualStudioTabControl1.SelectTab(newTab);
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        openFileDialog1.Title = "Open";
                        textBox.Text = File.ReadAllText(openFileDialog1.FileName);
                    }
                }
            }
            catch { }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                        using (StreamWriter sw = new StreamWriter(s))
                        {
                            sw.Write(textBox.Text);
                        }
                    }
                }
            }
            catch { }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    textBox.Text = "";
                }
            }
            catch { }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            ScriptHub openform = new ScriptHub();
            openform.Show();
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            Settings openform = new Settings();
            openform.Show();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    module.ExecuteScript(textBox.Text);
                }
            }
            catch { }
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    module.ExecuteScript(textBox.Text);
                }
            }
            catch { }
        }

        private void attachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    textBox.Text = "";
                }
            }
            catch { }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        openFileDialog1.Title = "Open";
                        fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    }
                }
            }
            catch { }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                        using (StreamWriter sw = new StreamWriter(s))
                        {
                            sw.Write(fastColoredTextBox1.Text);
                        }
                    }
                }
            }
            catch { }
        }
    }
    }

