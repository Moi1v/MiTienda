using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MiTienda
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cmbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvEmpleados.AutoGenerateColumns = true;
            cmbSucursal.Items.AddRange(new string[] { "Sucursal 1", "Sucursal 2", "Sucursal 3" });
        }
        private void button2_Click(object sender, EventArgs e)
        {
            log_in designedForm = new log_in();
            designedForm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //EY MUY BUENAS GUAPISIMOS AQUI VEGETTA 777 EN UN GAMEPLAY VIDIRECTO DE MUNDO VEGETTA :)
        }
    }
}

