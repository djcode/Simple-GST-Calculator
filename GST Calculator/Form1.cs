using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GST_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_exGST_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_exGST.Text,"^(\\$??)(\\d+)(\\.??)(\\d*)"))
            {
                
                float exGST = txt_exGST.Text.StartsWith("$") ? float.Parse(txt_exGST.Text.TrimStart('$')) : float.Parse(txt_exGST.Text);
                float incGST = exGST * (float)1.1;
                float GST = incGST - exGST;
                txt_exGST.Text = string.Format("${0:f2}", exGST);
                txt_incGST.Text = string.Format("${0:f2}", incGST);
                txt_GST.Text = string.Format("${0:f2}", GST);
            }
        }

        private void txt_incGST_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_incGST.Text, "^(\\$??)(\\d+)(\\.??)(\\d*)"))
            {
                float incGST = txt_incGST.Text.StartsWith("$") ? float.Parse(txt_incGST.Text.TrimStart('$')) : float.Parse(txt_incGST.Text);
                float exGST = incGST / (float)1.1;
                float GST = incGST - exGST;
                txt_exGST.Text = string.Format("${0:f2}", exGST);
                txt_incGST.Text = string.Format("${0:f2}", incGST);
                txt_GST.Text = string.Format("${0:f2}", GST);
            }
        }
    }
}
