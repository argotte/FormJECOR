using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPbobsCOM;

namespace FormJECOR
{
    public partial class Asignar : Form
    {
        public Asignar()
        {
            InitializeComponent();
            //oSapCompany.CreateCompany();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
