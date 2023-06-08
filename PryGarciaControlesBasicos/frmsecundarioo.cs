using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGarciaControlesBasicos
{
    public partial class frmsecundarioo : Form
    {
        public frmsecundarioo()
        {
            InitializeComponent();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            lblTexto.Text = txtTexto.Text;
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked)
            {
                txtTexto.ForeColor = Color.Blue;
                lblTexto.ForeColor = Color.Blue;
            }
            else if (optRojo.Checked)
            {
                txtTexto.ForeColor = Color.Red;
                lblTexto.ForeColor = Color.Red;
            }
        }

        private void cmdEscribir_Click(object sender, EventArgs e)
        {
            lblTexto.Text = "";
            if (chkLourdes.Checked)
            {
                lblTexto.Text += chkLourdes.Text + " ";
            }
            if (chkJasmin.Checked)
            {
                lblTexto.Text += chkJasmin.Text + " ";
            }
            if (chkGarcia.Checked)
            {
                lblTexto.Text += chkGarcia.Text + " ";
            }
            if (chkLourdes.Checked == false && chkJasmin.Checked == false && chkGarcia.Checked == false)
            {
                lblTexto.Text = "Su texto aparecera aqui...";
            }

            //List<CheckBox> list = new List<CheckBox>();
            //list.Add(chkLucas); list.Add(chkSebastian); list.Add(chkValinotti);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].Checked)
            //    {
            //        lblTexto.Text += list[i].Text + " ";
            //    }
            //}
        }

        private void frmSecundarioo_Load(object sender, EventArgs e)
        {

        }
    }
}
