namespace MiTienda
{
    partial class Employee_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_management));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            BTNReturn = new Button();
            button1 = new Button();
            button2 = new Button();
            btnSearch = new Button();
            lblTiempo = new Label();
            Sales = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 0;
            label1.Text = "Codigo Empleado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Julio", "Junio", "Agosto", "Octubre", "Septiembre", "Noviembre", "Diciembre" });
            comboBox1.Location = new Point(160, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 17);
            label3.Name = "label3";
            label3.Size = new Size(33, 17);
            label3.TabIndex = 5;
            label3.Text = "Mes";
            // 
            // BTNReturn
            // 
            BTNReturn.Location = new Point(89, 214);
            BTNReturn.Name = "BTNReturn";
            BTNReturn.Size = new Size(177, 38);
            BTNReturn.TabIndex = 6;
            BTNReturn.Text = "Return";
            BTNReturn.UseVisualStyleBackColor = true;
            BTNReturn.Click += BTNReturn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(314, 229);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(318, 224);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(272, 214);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(177, 38);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(533, 12);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(36, 15);
            lblTiempo.TabIndex = 10;
            lblTiempo.Text = "Time:";
            // 
            // Sales
            // 
            Sales.AutoSize = true;
            Sales.Location = new Point(533, 52);
            Sales.Name = "Sales";
            Sales.Size = new Size(36, 15);
            Sales.TabIndex = 11;
            Sales.Text = "Sales:";
            // 
            // Employee_management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sales);
            Controls.Add(lblTiempo);
            Controls.Add(btnSearch);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BTNReturn);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Employee_management";
            Text = "Employee management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Button BTNReturn;
        private Button button1;
        private Button button2;
        private Button btnSearch;
        private Label lblTiempo;
        private Label Sales;
    }
}