namespace SistemaGestionVacaciones1
{
    partial class frmRH1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRH1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.dgvRH = new System.Windows.Forms.DataGridView();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_acred_vaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoVacaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblHola = new System.Windows.Forms.Label();
            this.btnRE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRE);
            this.groupBox1.Controls.Add(this.btnCV);
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "MENÚ";
            // 
            // btnCV
            // 
            this.btnCV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCV.Image = ((System.Drawing.Image)(resources.GetObject("btnCV.Image")));
            this.btnCV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCV.Location = new System.Drawing.Point(17, 68);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(338, 44);
            this.btnCV.TabIndex = 0;
            this.btnCV.Text = "CÁLCULO VACACIONES";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÓDULO RECURSOS HUMANOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1200, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "=================================================================================" +
    "==================";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 675);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1200, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "=================================================================================" +
    "==================";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(938, 109);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(0, 25);
            this.lblBienvenida.TabIndex = 5;
            // 
            // dgvRH
            // 
            this.dgvRH.BackgroundColor = System.Drawing.Color.White;
            this.dgvRH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_empleado,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.fecha_acred_vaca,
            this.saldoVacaciones});
            this.dgvRH.Location = new System.Drawing.Point(434, 208);
            this.dgvRH.Name = "dgvRH";
            this.dgvRH.RowHeadersWidth = 51;
            this.dgvRH.RowTemplate.Height = 24;
            this.dgvRH.Size = new System.Drawing.Size(806, 305);
            this.dgvRH.TabIndex = 6;
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "Cédula";
            this.id_empleado.MinimumWidth = 6;
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // apellido1
            // 
            this.apellido1.HeaderText = "Primer Apellido";
            this.apellido1.MinimumWidth = 6;
            this.apellido1.Name = "apellido1";
            this.apellido1.Width = 125;
            // 
            // apellido2
            // 
            this.apellido2.HeaderText = "Segundo Apellido";
            this.apellido2.MinimumWidth = 6;
            this.apellido2.Name = "apellido2";
            this.apellido2.Width = 125;
            // 
            // fecha_acred_vaca
            // 
            this.fecha_acred_vaca.HeaderText = "Fecha Acreditación Vacaciones";
            this.fecha_acred_vaca.MinimumWidth = 6;
            this.fecha_acred_vaca.Name = "fecha_acred_vaca";
            this.fecha_acred_vaca.Width = 125;
            // 
            // saldoVacaciones
            // 
            this.saldoVacaciones.HeaderText = "Saldo de Vacaciones";
            this.saldoVacaciones.MinimumWidth = 6;
            this.saldoVacaciones.Name = "saldoVacaciones";
            this.saldoVacaciones.Width = 125;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1099, 49);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHola.Location = new System.Drawing.Point(910, 109);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(64, 24);
            this.lblHola.TabIndex = 8;
            this.lblHola.Text = "Saludo";
            // 
            // btnRE
            // 
            this.btnRE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRE.Image = ((System.Drawing.Image)(resources.GetObject("btnRE.Image")));
            this.btnRE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRE.Location = new System.Drawing.Point(17, 146);
            this.btnRE.Name = "btnRE";
            this.btnRE.Size = new System.Drawing.Size(338, 44);
            this.btnRE.TabIndex = 2;
            this.btnRE.Text = "REGISTRAR EMPLEADO";
            this.btnRE.UseVisualStyleBackColor = true;
            this.btnRE.Click += new System.EventHandler(this.btnRE_Click);
            // 
            // frmRH1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1252, 709);
            this.Controls.Add(this.lblHola);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvRH);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRH1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRH1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.DataGridView dgvRH;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_acred_vaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoVacaciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Button btnRE;
    }
}