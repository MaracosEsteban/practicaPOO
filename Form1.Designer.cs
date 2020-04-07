namespace PraciticaPOO1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBoxOperacion = new System.Windows.Forms.ComboBox();
            this.cBoxCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butConfirmarOperacion = new System.Windows.Forms.Button();
            this.tBoxTitular = new System.Windows.Forms.TextBox();
            this.tBoxNumeroCuenta = new System.Windows.Forms.TextBox();
            this.tBoxSaldoCuenta = new System.Windows.Forms.TextBox();
            this.tBoxMontoInresar = new System.Windows.Forms.TextBox();
            this.tBoxMontoRetirar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBoxOperacion
            // 
            this.cBoxOperacion.DisplayMember = "2";
            this.cBoxOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxOperacion.FormattingEnabled = true;
            this.cBoxOperacion.Items.AddRange(new object[] {
            "INGRESAR",
            "CONSULTAR",
            "INFORMAR",
            "RETIRAR"});
            this.cBoxOperacion.Location = new System.Drawing.Point(618, 68);
            this.cBoxOperacion.Name = "cBoxOperacion";
            this.cBoxOperacion.Size = new System.Drawing.Size(168, 28);
            this.cBoxOperacion.TabIndex = 2;
            this.cBoxOperacion.SelectedIndexChanged += new System.EventHandler(this.cBoxOperacion_SelectedIndexChanged);
            // 
            // cBoxCuenta
            // 
            this.cBoxCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCuenta.FormattingEnabled = true;
            this.cBoxCuenta.Items.AddRange(new object[] {
            "Javier Miras",
            "José Pérez",
            "Andrés Picó"});
            this.cBoxCuenta.Location = new System.Drawing.Point(618, 12);
            this.cBoxCuenta.Name = "cBoxCuenta";
            this.cBoxCuenta.Size = new System.Drawing.Size(245, 28);
            this.cBoxCuenta.TabIndex = 1;
            this.cBoxCuenta.SelectedIndexChanged += new System.EventHandler(this.cBoxCuenta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija la cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elija el Tipo de operación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titular cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto a retirar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Saldo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Monto a ingresar:";
            // 
            // butConfirmarOperacion
            // 
            this.butConfirmarOperacion.Location = new System.Drawing.Point(974, 506);
            this.butConfirmarOperacion.Name = "butConfirmarOperacion";
            this.butConfirmarOperacion.Size = new System.Drawing.Size(253, 34);
            this.butConfirmarOperacion.TabIndex = 9;
            this.butConfirmarOperacion.Text = "Confirmar Operación";
            this.butConfirmarOperacion.UseVisualStyleBackColor = true;
            this.butConfirmarOperacion.Click += new System.EventHandler(this.butConfirmarOperacion_Click);
            // 
            // tBoxTitular
            // 
            this.tBoxTitular.Enabled = false;
            this.tBoxTitular.Location = new System.Drawing.Point(628, 206);
            this.tBoxTitular.Name = "tBoxTitular";
            this.tBoxTitular.Size = new System.Drawing.Size(180, 26);
            this.tBoxTitular.TabIndex = 10;
            // 
            // tBoxNumeroCuenta
            // 
            this.tBoxNumeroCuenta.Enabled = false;
            this.tBoxNumeroCuenta.Location = new System.Drawing.Point(628, 259);
            this.tBoxNumeroCuenta.Name = "tBoxNumeroCuenta";
            this.tBoxNumeroCuenta.Size = new System.Drawing.Size(179, 26);
            this.tBoxNumeroCuenta.TabIndex = 11;
            // 
            // tBoxSaldoCuenta
            // 
            this.tBoxSaldoCuenta.Enabled = false;
            this.tBoxSaldoCuenta.Location = new System.Drawing.Point(628, 305);
            this.tBoxSaldoCuenta.Name = "tBoxSaldoCuenta";
            this.tBoxSaldoCuenta.Size = new System.Drawing.Size(180, 26);
            this.tBoxSaldoCuenta.TabIndex = 12;
            // 
            // tBoxMontoInresar
            // 
            this.tBoxMontoInresar.Enabled = false;
            this.tBoxMontoInresar.Location = new System.Drawing.Point(631, 356);
            this.tBoxMontoInresar.Name = "tBoxMontoInresar";
            this.tBoxMontoInresar.Size = new System.Drawing.Size(174, 26);
            this.tBoxMontoInresar.TabIndex = 13;
            // 
            // tBoxMontoRetirar
            // 
            this.tBoxMontoRetirar.Enabled = false;
            this.tBoxMontoRetirar.Location = new System.Drawing.Point(631, 412);
            this.tBoxMontoRetirar.Name = "tBoxMontoRetirar";
            this.tBoxMontoRetirar.Size = new System.Drawing.Size(174, 26);
            this.tBoxMontoRetirar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 648);
            this.Controls.Add(this.tBoxMontoRetirar);
            this.Controls.Add(this.tBoxMontoInresar);
            this.Controls.Add(this.tBoxSaldoCuenta);
            this.Controls.Add(this.tBoxNumeroCuenta);
            this.Controls.Add(this.tBoxTitular);
            this.Controls.Add(this.butConfirmarOperacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxCuenta);
            this.Controls.Add(this.cBoxOperacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxOperacion;
        private System.Windows.Forms.ComboBox cBoxCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butConfirmarOperacion;
        private System.Windows.Forms.TextBox tBoxTitular;
        private System.Windows.Forms.TextBox tBoxNumeroCuenta;
        private System.Windows.Forms.TextBox tBoxSaldoCuenta;
        private System.Windows.Forms.TextBox tBoxMontoInresar;
        private System.Windows.Forms.TextBox tBoxMontoRetirar;
    }
}

