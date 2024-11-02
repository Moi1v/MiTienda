using MiTienda.Clase__Temporal_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTienda
{
    public partial class Form4 : Form
    {
        private List<Producto> productos = new List<Producto>();
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto
            {
                Codigo = TxtCode.Text,
                Nombre = txtName.Text,
                Descripcion = txtDescription.Text,
                Precio = Convert.ToDecimal(txtPrice.Text),
                Cantidad = Convert.ToInt32(txtStock.Text),
            };

            productos.Add(nuevoProducto);
            MessageBox.Show("Producto guardado temporalmente.");

            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            TxtCode.Clear();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            string codigo = TxtCode.Text;
            Producto producto = productos.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                producto.Nombre = txtName.Text;
                producto.Descripcion = txtDescription.Text;
                producto.Precio = Convert.ToDecimal(txtPrice.Text);
                producto.Cantidad = Convert.ToInt32(txtStock.Text);
                MessageBox.Show("Producto actualizado temporalmente.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string codigo = TxtCode.Text;
            Producto producto = productos.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                productos.Remove(producto);
                MessageBox.Show("Producto eliminado temporalmente.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void Btnconsult_Click(object sender, EventArgs e)
        {
            string codigo = txtName.Text;
            Producto producto = productos.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                txtName.Text = producto.Nombre;
                txtDescription.Text = producto.Descripcion;
                txtPrice.Text = producto.Precio.ToString();
                txtStock.Text = producto.Cantidad.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }
    }
}

