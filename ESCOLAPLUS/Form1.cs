using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ESCOLAPLUS
{
    public partial class FormHOME:Form
    {
        Operações MinhaOperação = new Operações();
        public FormHOME()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        

        public void btnINSERIR_Click(object sender, EventArgs e)
        {
            pnlINSERIR.Visible = true;
            //MinhaOperação.CodigoAluno();
            txtNOME.Focus();
            txtEMAIL.Clear();
            txtNOME.Clear();
            mskTELEFONE.Clear();
        }
        public void btnADDLIST_Click(object sender, EventArgs e)
        {
            MinhaOperação.Inserir();
            btnINSERIR_Click(sender, e);
        }

        private void txtEMAIL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnADDLIST_Click(sender, e);
            }
        }

        private void txtNOME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskTELEFONE.Focus();
            }
        }

        private void mskTELEFONE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEMAIL.Focus();
            }
        }

    }
}