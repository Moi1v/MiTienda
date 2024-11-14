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
        public Employee_management()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BTNReturn_Click(object sender, EventArgs e)
        {
            Menu designedForm = new Menu();
            designedForm.Show();
            this.Hide();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;
            string nombre = textBox2.Text;

            var employee = ObtenerEmpleado(codigo, nombre);

            if (employee != null)
            {

                flowLayoutPanel1.Text = $"Tiempo en la tienda: {CalcularTiempoEmpleo(employee.FechaIngreso).Days / 365} años";


                double totalVentas = CalcularTotalVentas(employee.Id);
                flowLayoutPanel1.Text = $"Las ventas Totales son: ${totalVentas}";
            }
            else
            {
                MessageBox.Show("Empleado no encontrado.");
            }
        }

        private Empleado ObtenerEmpleado(string codigo, string nombre)
        {

            if (codigo == "123" || nombre.Equals("Juan Pérez", StringComparison.OrdinalIgnoreCase))
            {
                return new Empleado { Id = "123", Nombre = "Juan Pérez", FechaIngreso = new DateTime(2019, 5, 10) };
            }
            return null;
        }

        private TimeSpan CalcularTiempoEmpleo(DateTime fechaIngreso)
        {
            return DateTime.Now - fechaIngreso;
        }

        private double CalcularTotalVentas(string employeeId)
        {

            var ventas = new[]
            {
            new { Fecha = "2023-11-01", Monto = 250.00 },
            new { Fecha = "2023-11-02", Monto = 100.00 }
        };


            return ventas.Sum(venta => venta.Monto);
        }

        public class Empleado
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public DateTime FechaIngreso { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu designedForm = new Menu();
            designedForm.Show();
            this.Hide();
        }
    }
}
