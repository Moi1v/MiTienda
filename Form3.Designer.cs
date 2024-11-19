namespace MiTienda
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dgvEmpleados = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Sucursal = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ID_Empleado = new DataGridViewTextBoxColumn();
            dtpMes = new DateTimePicker();
            cmbSucursal = new ComboBox();
            txtNombre = new TextBox();
            txtIdEmpleado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { Fecha, Sucursal, Nombre, ID_Empleado });
            dgvEmpleados.Location = new Point(385, 32);
            dgvEmpleados.Margin = new Padding(3, 2, 3, 2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(484, 458);
            dgvEmpleados.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Sucursal
            // 
            Sucursal.HeaderText = "Sucursal";
            Sucursal.MinimumWidth = 6;
            Sucursal.Name = "Sucursal";
            Sucursal.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // ID_Empleado
            // 
            ID_Empleado.HeaderText = "ID Empleado";
            ID_Empleado.MinimumWidth = 6;
            ID_Empleado.Name = "ID_Empleado";
            ID_Empleado.Width = 125;
            // 
            // dtpMes
            // 
            dtpMes.Location = new Point(150, 39);
            dtpMes.Margin = new Padding(3, 2, 3, 2);
            dtpMes.Name = "dtpMes";
            dtpMes.Size = new Size(219, 23);
            dtpMes.TabIndex = 1;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(150, 74);
            cmbSucursal.Margin = new Padding(3, 2, 3, 2);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(219, 23);
            cmbSucursal.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 129);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(168, 164);
            txtIdEmpleado.Margin = new Padding(3, 2, 3, 2);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(182, 23);
            txtIdEmpleado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 128);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 164);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 8;
            label2.Text = "ID Empleado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 40);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 9;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 77);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "Sucursal:";
            // 
            // button1
            // 
            button1.Location = new Point(567, 510);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(681, 510);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 562);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdEmpleado);
            Controls.Add(txtNombre);
            Controls.Add(cmbSucursal);
            Controls.Add(dtpMes);
            Controls.Add(dgvEmpleados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Employee management";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private DateTimePicker dtpMes;
        private ComboBox cmbSucursal;
        private TextBox txtNombre;
        private TextBox txtIdEmpleado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Sucursal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ID_Empleado;
        private Button button1;
        private Button button2;
    }
}