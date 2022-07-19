using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormJECOR
{
    public partial class Inicio : Form
    {
        SapCompany oSapCompany = new SapCompany();
        public Inicio()
        {
            InitializeComponent();
            oSapCompany.CreateCompany();

        }

        //     private void Form1_Load(object sender, EventArgs e)
        //   {
        //
        //    }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            using (Asignar asignar = new Asignar()) {
               // asignar.Visible = false;
            asignar.ShowDialog();
            
             }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (Consultar consultar = new Consultar()) 
            consultar.ShowDialog();
           
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
