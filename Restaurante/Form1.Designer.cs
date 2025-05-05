namespace Restaurante
{
    partial class Form1
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
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvSistemaHotel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.cboxTamañoHabitacion = new System.Windows.Forms.ComboBox();
            this.txtDiasAHospedarse = new System.Windows.Forms.TextBox();
            this.txtCodigoReservacion = new System.Windows.Forms.TextBox();
            this.lblTotalAFacturar = new System.Windows.Forms.Label();
            this.lblCostoTipoHabitacion = new System.Windows.Forms.Label();
            this.lblPrecioTotalDias = new System.Windows.Forms.Label();
            this.lblPrecioPorDia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemaHotel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.Location = new System.Drawing.Point(823, 12);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(15, 19);
            this.lblFechaActual.TabIndex = 27;
            this.lblFechaActual.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(715, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Fecha actual:";
            // 
            // dgvSistemaHotel
            // 
            this.dgvSistemaHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSistemaHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSistemaHotel.Location = new System.Drawing.Point(24, 210);
            this.dgvSistemaHotel.Name = "dgvSistemaHotel";
            this.dgvSistemaHotel.ReadOnly = true;
            this.dgvSistemaHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSistemaHotel.Size = new System.Drawing.Size(933, 236);
            this.dgvSistemaHotel.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxTipoHabitacion);
            this.groupBox1.Controls.Add(this.cboxTamañoHabitacion);
            this.groupBox1.Controls.Add(this.txtDiasAHospedarse);
            this.groupBox1.Controls.Add(this.txtCodigoReservacion);
            this.groupBox1.Controls.Add(this.lblTotalAFacturar);
            this.groupBox1.Controls.Add(this.lblCostoTipoHabitacion);
            this.groupBox1.Controls.Add(this.lblPrecioTotalDias);
            this.groupBox1.Controls.Add(this.lblPrecioPorDia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 152);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // cboxTipoHabitacion
            // 
            this.cboxTipoHabitacion.FormattingEnabled = true;
            this.cboxTipoHabitacion.Items.AddRange(new object[] {
            "Bronce",
            "Oro",
            "Diamante",
            "Exclusiva"});
            this.cboxTipoHabitacion.Location = new System.Drawing.Point(163, 113);
            this.cboxTipoHabitacion.Name = "cboxTipoHabitacion";
            this.cboxTipoHabitacion.Size = new System.Drawing.Size(124, 21);
            this.cboxTipoHabitacion.TabIndex = 19;
            // 
            // cboxTamañoHabitacion
            // 
            this.cboxTamañoHabitacion.FormattingEnabled = true;
            this.cboxTamañoHabitacion.Items.AddRange(new object[] {
            "Individual",
            "Compartida",
            "Suite",
            "Presidencial"});
            this.cboxTamañoHabitacion.Location = new System.Drawing.Point(163, 85);
            this.cboxTamañoHabitacion.Name = "cboxTamañoHabitacion";
            this.cboxTamañoHabitacion.Size = new System.Drawing.Size(124, 21);
            this.cboxTamañoHabitacion.TabIndex = 18;
            // 
            // txtDiasAHospedarse
            // 
            this.txtDiasAHospedarse.Location = new System.Drawing.Point(163, 57);
            this.txtDiasAHospedarse.Name = "txtDiasAHospedarse";
            this.txtDiasAHospedarse.Size = new System.Drawing.Size(124, 20);
            this.txtDiasAHospedarse.TabIndex = 17;
            // 
            // txtCodigoReservacion
            // 
            this.txtCodigoReservacion.Location = new System.Drawing.Point(163, 26);
            this.txtCodigoReservacion.Name = "txtCodigoReservacion";
            this.txtCodigoReservacion.ReadOnly = true;
            this.txtCodigoReservacion.Size = new System.Drawing.Size(124, 20);
            this.txtCodigoReservacion.TabIndex = 16;
            // 
            // lblTotalAFacturar
            // 
            this.lblTotalAFacturar.AutoSize = true;
            this.lblTotalAFacturar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAFacturar.Location = new System.Drawing.Point(547, 114);
            this.lblTotalAFacturar.Name = "lblTotalAFacturar";
            this.lblTotalAFacturar.Size = new System.Drawing.Size(15, 19);
            this.lblTotalAFacturar.TabIndex = 12;
            this.lblTotalAFacturar.Text = "-";
            // 
            // lblCostoTipoHabitacion
            // 
            this.lblCostoTipoHabitacion.AutoSize = true;
            this.lblCostoTipoHabitacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTipoHabitacion.Location = new System.Drawing.Point(547, 84);
            this.lblCostoTipoHabitacion.Name = "lblCostoTipoHabitacion";
            this.lblCostoTipoHabitacion.Size = new System.Drawing.Size(15, 19);
            this.lblCostoTipoHabitacion.TabIndex = 11;
            this.lblCostoTipoHabitacion.Text = "-";
            // 
            // lblPrecioTotalDias
            // 
            this.lblPrecioTotalDias.AutoSize = true;
            this.lblPrecioTotalDias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotalDias.Location = new System.Drawing.Point(547, 56);
            this.lblPrecioTotalDias.Name = "lblPrecioTotalDias";
            this.lblPrecioTotalDias.Size = new System.Drawing.Size(15, 19);
            this.lblPrecioTotalDias.TabIndex = 10;
            this.lblPrecioTotalDias.Text = "-";
            // 
            // lblPrecioPorDia
            // 
            this.lblPrecioPorDia.AutoSize = true;
            this.lblPrecioPorDia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPorDia.Location = new System.Drawing.Point(547, 27);
            this.lblPrecioPorDia.Name = "lblPrecioPorDia";
            this.lblPrecioPorDia.Size = new System.Drawing.Size(15, 19);
            this.lblPrecioPorDia.TabIndex = 9;
            this.lblPrecioPorDia.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total a Facturar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Costo tipo habitación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Precio total días:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(370, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Precio por día:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Habitación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tamaño Habitación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Días a hospedarse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Reservación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "SISTEMA HOTEL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 477);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvSistemaHotel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemaHotel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvSistemaHotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxTipoHabitacion;
        private System.Windows.Forms.ComboBox cboxTamañoHabitacion;
        private System.Windows.Forms.TextBox txtDiasAHospedarse;
        private System.Windows.Forms.TextBox txtCodigoReservacion;
        private System.Windows.Forms.Label lblTotalAFacturar;
        private System.Windows.Forms.Label lblCostoTipoHabitacion;
        private System.Windows.Forms.Label lblPrecioTotalDias;
        private System.Windows.Forms.Label lblPrecioPorDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

