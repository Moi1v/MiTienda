namespace MiTienda
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtCode = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            BtnSave = new Button();
            Btnconsult = new Button();
            BtnRefresh = new Button();
            BtnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 51);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 77);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 104);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 131);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 4;
            label5.Text = "cantidad en inventario";
            // 
            // TxtCode
            // 
            TxtCode.Location = new Point(159, 16);
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(100, 23);
            TxtCode.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(159, 69);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(159, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(159, 123);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 9;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(24, 203);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(95, 41);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // Btnconsult
            // 
            Btnconsult.Location = new Point(125, 203);
            Btnconsult.Name = "Btnconsult";
            Btnconsult.Size = new Size(95, 41);
            Btnconsult.TabIndex = 11;
            Btnconsult.Text = "Consultar";
            Btnconsult.UseVisualStyleBackColor = true;
            Btnconsult.Click += Btnconsult_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(226, 203);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(95, 41);
            BtnRefresh.TabIndex = 12;
            BtnRefresh.Text = "Actualizar";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(327, 203);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 41);
            BtnDelete.TabIndex = 13;
            BtnDelete.Text = "Eliminar";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDelete);
            Controls.Add(BtnRefresh);
            Controls.Add(Btnconsult);
            Controls.Add(BtnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(TxtCode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Product Maintenance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtCode;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button BtnSave;
        private Button Btnconsult;
        private Button BtnRefresh;
        private Button BtnDelete;
    }
}