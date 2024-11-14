using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiTienda
{
    public partial class Employee_management : Form
    {
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Menu designedForm = new Menu();
            designedForm.Show();
            this.Hide();
        }
    }
}
