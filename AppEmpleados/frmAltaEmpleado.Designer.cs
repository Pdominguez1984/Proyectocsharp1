namespace AppEmpleados
{
    partial class frmAltaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaEmpleado));
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnCancelarCargaEmpleado = new System.Windows.Forms.Button();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDniEmpleado = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbCasado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(170, 251);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEmpleado.TabIndex = 0;
            this.btnAgregarEmpleado.Text = "Aceptar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnCancelarCargaEmpleado
            // 
            this.btnCancelarCargaEmpleado.Location = new System.Drawing.Point(252, 251);
            this.btnCancelarCargaEmpleado.Name = "btnCancelarCargaEmpleado";
            this.btnCancelarCargaEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCargaEmpleado.TabIndex = 1;
            this.btnCancelarCargaEmpleado.Text = "Cancelar";
            this.btnCancelarCargaEmpleado.UseVisualStyleBackColor = true;
            this.btnCancelarCargaEmpleado.Click += new System.EventHandler(this.btnCancelarCargaEmpleado_Click);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(170, 30);
            this.txtNombreEmpleado.MaxLength = 99;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(146, 20);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(170, 82);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(49, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.Location = new System.Drawing.Point(170, 56);
            this.txtDniEmpleado.MaxLength = 9;
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(63, 20);
            this.txtDniEmpleado.TabIndex = 3;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(170, 133);
            this.txtSueldo.MaxLength = 12;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(49, 20);
            this.txtSueldo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Casado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sueldo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbCasado);
            this.groupBox1.Controls.Add(this.txtNombreEmpleado);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDniEmpleado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(94, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Empleado";
            // 
            // chbCasado
            // 
            this.chbCasado.AutoSize = true;
            this.chbCasado.Location = new System.Drawing.Point(170, 110);
            this.chbCasado.Name = "chbCasado";
            this.chbCasado.Size = new System.Drawing.Size(15, 14);
            this.chbCasado.TabIndex = 7;
            this.chbCasado.UseVisualStyleBackColor = true;
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(652, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelarCargaEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAltaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta : Empleado";
            this.Load += new System.EventHandler(this.frmAltaEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnCancelarCargaEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDniEmpleado;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbCasado;
    }
}