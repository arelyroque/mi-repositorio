namespace SistemaGestionVacaciones1
{
    partial class CalculoVacaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldoVacaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReconocimiento = new System.Windows.Forms.Button();
            this.btnCalcVacaciones = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAjusteSuma = new System.Windows.Forms.TextBox();
            this.txtAjusteResta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnRealizarAjuste = new System.Windows.Forms.Button();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.txtNombreCompletoEmpleado = new System.Windows.Forms.TextBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtFechaAcreditacion = new System.Windows.Forms.TextBox();
            this.btnGuardarVac = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cédula del empleado:";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(358, 95);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(202, 30);
            this.txtIdEmpleado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CALCULADORA DE VACACIONES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtFechaAcreditacion);
            this.groupBox1.Controls.Add(this.txtFechaIngreso);
            this.groupBox1.Controls.Add(this.txtNombreCompletoEmpleado);
            this.groupBox1.Controls.Add(this.txtSaldoInicial);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnReconocimiento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 247);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha de ingreso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Saldo inicial de vacaciones:";
            // 
            // txtSaldoVacaciones
            // 
            this.txtSaldoVacaciones.Location = new System.Drawing.Point(358, 151);
            this.txtSaldoVacaciones.Name = "txtSaldoVacaciones";
            this.txtSaldoVacaciones.Size = new System.Drawing.Size(202, 30);
            this.txtSaldoVacaciones.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Saldo de vacaciones:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Fecha de acreditación :";
            // 
            // btnReconocimiento
            // 
            this.btnReconocimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReconocimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReconocimiento.ForeColor = System.Drawing.Color.Black;
            this.btnReconocimiento.Location = new System.Drawing.Point(711, 44);
            this.btnReconocimiento.Name = "btnReconocimiento";
            this.btnReconocimiento.Size = new System.Drawing.Size(190, 69);
            this.btnReconocimiento.TabIndex = 8;
            this.btnReconocimiento.Text = "Reconocimiento de vacaciones";
            this.btnReconocimiento.UseVisualStyleBackColor = false;
            // 
            // btnCalcVacaciones
            // 
            this.btnCalcVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalcVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcVacaciones.Location = new System.Drawing.Point(607, 105);
            this.btnCalcVacaciones.Name = "btnCalcVacaciones";
            this.btnCalcVacaciones.Size = new System.Drawing.Size(179, 62);
            this.btnCalcVacaciones.TabIndex = 9;
            this.btnCalcVacaciones.Text = "Calcular Vacaciones";
            this.btnCalcVacaciones.UseVisualStyleBackColor = false;
            this.btnCalcVacaciones.Click += new System.EventHandler(this.btnCalcVacaciones_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.btnRealizarAjuste);
            this.groupBox2.Controls.Add(this.txtComentario);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtAjusteResta);
            this.groupBox2.Controls.Add(this.txtAjusteSuma);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(27, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 131);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajuste de vacaciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Sumar vacaciones:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Restar vacaciones:";
            // 
            // txtAjusteSuma
            // 
            this.txtAjusteSuma.Location = new System.Drawing.Point(221, 47);
            this.txtAjusteSuma.Name = "txtAjusteSuma";
            this.txtAjusteSuma.Size = new System.Drawing.Size(93, 30);
            this.txtAjusteSuma.TabIndex = 11;
            // 
            // txtAjusteResta
            // 
            this.txtAjusteResta.Location = new System.Drawing.Point(221, 84);
            this.txtAjusteResta.Name = "txtAjusteResta";
            this.txtAjusteResta.Size = new System.Drawing.Size(93, 30);
            this.txtAjusteResta.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(371, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(258, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Añadir comentario del ajuste";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(376, 47);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(253, 65);
            this.txtComentario.TabIndex = 14;
            // 
            // btnRealizarAjuste
            // 
            this.btnRealizarAjuste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRealizarAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarAjuste.Location = new System.Drawing.Point(711, 43);
            this.btnRealizarAjuste.Name = "btnRealizarAjuste";
            this.btnRealizarAjuste.Size = new System.Drawing.Size(190, 69);
            this.btnRealizarAjuste.TabIndex = 11;
            this.btnRealizarAjuste.Text = "Realizar ajuste";
            this.btnRealizarAjuste.UseVisualStyleBackColor = false;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(304, 135);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(325, 30);
            this.txtSaldoInicial.TabIndex = 11;
            // 
            // txtNombreCompletoEmpleado
            // 
            this.txtNombreCompletoEmpleado.Location = new System.Drawing.Point(304, 39);
            this.txtNombreCompletoEmpleado.Name = "txtNombreCompletoEmpleado";
            this.txtNombreCompletoEmpleado.Size = new System.Drawing.Size(325, 30);
            this.txtNombreCompletoEmpleado.TabIndex = 12;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(304, 83);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(325, 30);
            this.txtFechaIngreso.TabIndex = 13;
            // 
            // txtFechaAcreditacion
            // 
            this.txtFechaAcreditacion.Location = new System.Drawing.Point(304, 186);
            this.txtFechaAcreditacion.Name = "txtFechaAcreditacion";
            this.txtFechaAcreditacion.Size = new System.Drawing.Size(325, 30);
            this.txtFechaAcreditacion.TabIndex = 14;
            // 
            // btnGuardarVac
            // 
            this.btnGuardarVac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardarVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVac.Location = new System.Drawing.Point(813, 105);
            this.btnGuardarVac.Name = "btnGuardarVac";
            this.btnGuardarVac.Size = new System.Drawing.Size(139, 62);
            this.btnGuardarVac.TabIndex = 11;
            this.btnGuardarVac.Text = "Guardar Registro";
            this.btnGuardarVac.UseVisualStyleBackColor = false;
            // 
            // CalculoVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(979, 642);
            this.Controls.Add(this.btnGuardarVac);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalcVacaciones);
            this.Controls.Add(this.txtSaldoVacaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculoVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculoVacaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldoVacaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReconocimiento;
        private System.Windows.Forms.Button btnCalcVacaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAjusteResta;
        private System.Windows.Forms.TextBox txtAjusteSuma;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreCompletoEmpleado;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Button btnRealizarAjuste;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtFechaAcreditacion;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.Button btnGuardarVac;
    }
}