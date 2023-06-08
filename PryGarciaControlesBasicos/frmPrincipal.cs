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
    public partial class frmPrincipal : Form
    {
        Random random = new Random();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString(); lblEjeY.Text = e.Y.ToString();
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = true;
        }

        private void lblBienvenida_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenida.Location = new Point(random.Next(10, 1000), random.Next(10, 800));
        }

        private void cmdSecundario_Click(object sender, EventArgs e)
        {
            frmSecundario frm = new frmSecundario();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
