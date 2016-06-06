namespace Plugin.MetodosPago.Frontend
{
    partial class ViewFormCheque
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
            this.cancelar = new System.Windows.Forms.Button();
            this.lbl_rut_cheque = new System.Windows.Forms.Label();
            this.lbl_fecha_cheque = new System.Windows.Forms.Label();
            this.x_dia_cheque = new System.Windows.Forms.ComboBox();
            this.x_anio_cheque = new System.Windows.Forms.ComboBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.x_monto = new System.Windows.Forms.TextBox();
            this.x_mes_cheque = new System.Windows.Forms.ComboBox();
            this.lbl_x_banco_cheque = new System.Windows.Forms.Label();
            this.lbl_info_cheque = new System.Windows.Forms.Label();
            this.rut_cheque = new System.Windows.Forms.TextBox();
            this.x_banco_cheque = new System.Windows.Forms.ComboBox();
            this.x_numero_cheque = new System.Windows.Forms.TextBox();
            this.lbl_x_numero_cheque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_cod_auth_cheque = new System.Windows.Forms.TextBox();
            this.x_tasas_interes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.x_nombre_completo_cheque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nro_cta_corriente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Transparent;
            this.cancelar.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelar.Location = new System.Drawing.Point(604, 264);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(90, 45);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_rut_cheque
            // 
            this.lbl_rut_cheque.AutoSize = true;
            this.lbl_rut_cheque.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rut_cheque.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rut_cheque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_rut_cheque.Location = new System.Drawing.Point(252, 45);
            this.lbl_rut_cheque.Name = "lbl_rut_cheque";
            this.lbl_rut_cheque.Size = new System.Drawing.Size(90, 35);
            this.lbl_rut_cheque.TabIndex = 100;
            this.lbl_rut_cheque.Text = "RUT Cheque";
            // 
            // lbl_fecha_cheque
            // 
            this.lbl_fecha_cheque.AutoSize = true;
            this.lbl_fecha_cheque.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha_cheque.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_cheque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_fecha_cheque.Location = new System.Drawing.Point(252, 226);
            this.lbl_fecha_cheque.Name = "lbl_fecha_cheque";
            this.lbl_fecha_cheque.Size = new System.Drawing.Size(48, 35);
            this.lbl_fecha_cheque.TabIndex = 103;
            this.lbl_fecha_cheque.Text = "Fecha";
            // 
            // x_dia_cheque
            // 
            this.x_dia_cheque.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_dia_cheque.FormattingEnabled = true;
            this.x_dia_cheque.Location = new System.Drawing.Point(258, 264);
            this.x_dia_cheque.Name = "x_dia_cheque";
            this.x_dia_cheque.Size = new System.Drawing.Size(52, 32);
            this.x_dia_cheque.TabIndex = 9;
            this.x_dia_cheque.SelectedIndexChanged += new System.EventHandler(this.x_dia_cheque_SelectedIndexChanged);
            this.x_dia_cheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_dia_cheque_KeyPress);
            // 
            // x_anio_cheque
            // 
            this.x_anio_cheque.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_anio_cheque.FormattingEnabled = true;
            this.x_anio_cheque.Location = new System.Drawing.Point(374, 264);
            this.x_anio_cheque.Name = "x_anio_cheque";
            this.x_anio_cheque.Size = new System.Drawing.Size(96, 32);
            this.x_anio_cheque.TabIndex = 11;
            this.x_anio_cheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_anio_cheque_KeyPress);
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.Color.Transparent;
            this.aceptar.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aceptar.Location = new System.Drawing.Point(522, 264);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(82, 45);
            this.aceptar.TabIndex = 7;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 35);
            this.label1.TabIndex = 102;
            this.label1.Text = "Monto";
            // 
            // x_monto
            // 
            this.x_monto.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_monto.Location = new System.Drawing.Point(34, 265);
            this.x_monto.MaxLength = 15;
            this.x_monto.Name = "x_monto";
            this.x_monto.Size = new System.Drawing.Size(142, 31);
            this.x_monto.TabIndex = 7;
            this.x_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monto_KeyPress);
            // 
            // x_mes_cheque
            // 
            this.x_mes_cheque.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_mes_cheque.FormattingEnabled = true;
            this.x_mes_cheque.Location = new System.Drawing.Point(316, 264);
            this.x_mes_cheque.Name = "x_mes_cheque";
            this.x_mes_cheque.Size = new System.Drawing.Size(52, 32);
            this.x_mes_cheque.TabIndex = 10;
            this.x_mes_cheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_mes_cheque_KeyPress);
            // 
            // lbl_x_banco_cheque
            // 
            this.lbl_x_banco_cheque.AutoSize = true;
            this.lbl_x_banco_cheque.BackColor = System.Drawing.Color.Transparent;
            this.lbl_x_banco_cheque.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x_banco_cheque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_x_banco_cheque.Location = new System.Drawing.Point(31, 45);
            this.lbl_x_banco_cheque.Name = "lbl_x_banco_cheque";
            this.lbl_x_banco_cheque.Size = new System.Drawing.Size(51, 35);
            this.lbl_x_banco_cheque.TabIndex = 105;
            this.lbl_x_banco_cheque.Text = "Banco";
            // 
            // lbl_info_cheque
            // 
            this.lbl_info_cheque.AutoSize = true;
            this.lbl_info_cheque.BackColor = System.Drawing.Color.Transparent;
            this.lbl_info_cheque.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_cheque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_info_cheque.Location = new System.Drawing.Point(266, 0);
            this.lbl_info_cheque.Name = "lbl_info_cheque";
            this.lbl_info_cheque.Size = new System.Drawing.Size(178, 54);
            this.lbl_info_cheque.TabIndex = 106;
            this.lbl_info_cheque.Text = "Datos del Cheque";
            // 
            // rut_cheque
            // 
            this.rut_cheque.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rut_cheque.Location = new System.Drawing.Point(258, 83);
            this.rut_cheque.MaxLength = 10;
            this.rut_cheque.Name = "rut_cheque";
            this.rut_cheque.Size = new System.Drawing.Size(213, 31);
            this.rut_cheque.TabIndex = 2;
            this.rut_cheque.TextChanged += new System.EventHandler(this.rut_cheque_TextChanged);
            // 
            // x_banco_cheque
            // 
            this.x_banco_cheque.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_banco_cheque.FormattingEnabled = true;
            this.x_banco_cheque.Location = new System.Drawing.Point(35, 83);
            this.x_banco_cheque.Name = "x_banco_cheque";
            this.x_banco_cheque.Size = new System.Drawing.Size(212, 32);
            this.x_banco_cheque.TabIndex = 1;
            this.x_banco_cheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_banco_cheque_KeyPress);
            // 
            // x_numero_cheque
            // 
            this.x_numero_cheque.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_numero_cheque.Location = new System.Drawing.Point(34, 172);
            this.x_numero_cheque.MaxLength = 20;
            this.x_numero_cheque.Name = "x_numero_cheque";
            this.x_numero_cheque.Size = new System.Drawing.Size(213, 31);
            this.x_numero_cheque.TabIndex = 4;
            this.x_numero_cheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_numero_cheque_KeyPress);
            // 
            // lbl_x_numero_cheque
            // 
            this.lbl_x_numero_cheque.AutoSize = true;
            this.lbl_x_numero_cheque.BackColor = System.Drawing.Color.Transparent;
            this.lbl_x_numero_cheque.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x_numero_cheque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_x_numero_cheque.Location = new System.Drawing.Point(31, 135);
            this.lbl_x_numero_cheque.Name = "lbl_x_numero_cheque";
            this.lbl_x_numero_cheque.Size = new System.Drawing.Size(102, 35);
            this.lbl_x_numero_cheque.TabIndex = 109;
            this.lbl_x_numero_cheque.Text = "Nro de Cheque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(254, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 35);
            this.label3.TabIndex = 111;
            this.label3.Text = "Código de Auth";
            // 
            // x_cod_auth_cheque
            // 
            this.x_cod_auth_cheque.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_cod_auth_cheque.Location = new System.Drawing.Point(260, 172);
            this.x_cod_auth_cheque.MaxLength = 20;
            this.x_cod_auth_cheque.Name = "x_cod_auth_cheque";
            this.x_cod_auth_cheque.Size = new System.Drawing.Size(213, 31);
            this.x_cod_auth_cheque.TabIndex = 5;
            this.x_cod_auth_cheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_cod_auth_cheque_KeyPress);
            // 
            // x_tasas_interes
            // 
            this.x_tasas_interes.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_tasas_interes.Location = new System.Drawing.Point(182, 265);
            this.x_tasas_interes.MaxLength = 4;
            this.x_tasas_interes.Name = "x_tasas_interes";
            this.x_tasas_interes.Size = new System.Drawing.Size(65, 31);
            this.x_tasas_interes.TabIndex = 8;
            this.x_tasas_interes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_tasas_interes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(176, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 35);
            this.label4.TabIndex = 113;
            this.label4.Text = "Tasas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(479, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 35);
            this.label5.TabIndex = 115;
            this.label5.Text = "Nombre Completo";
            // 
            // x_nombre_completo_cheque
            // 
            this.x_nombre_completo_cheque.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_nombre_completo_cheque.Location = new System.Drawing.Point(485, 172);
            this.x_nombre_completo_cheque.MaxLength = 45;
            this.x_nombre_completo_cheque.Name = "x_nombre_completo_cheque";
            this.x_nombre_completo_cheque.Size = new System.Drawing.Size(213, 31);
            this.x_nombre_completo_cheque.TabIndex = 6;
            this.x_nombre_completo_cheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_nombre_completo_cheque_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(475, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 35);
            this.label6.TabIndex = 117;
            this.label6.Text = "Nro Cuenta Corriente";
            // 
            // nro_cta_corriente
            // 
            this.nro_cta_corriente.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nro_cta_corriente.Location = new System.Drawing.Point(481, 83);
            this.nro_cta_corriente.MaxLength = 20;
            this.nro_cta_corriente.Name = "nro_cta_corriente";
            this.nro_cta_corriente.Size = new System.Drawing.Size(213, 31);
            this.nro_cta_corriente.TabIndex = 3;
            this.nro_cta_corriente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nro_cta_corriente_KeyPress);
            // 
            // ViewFormCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(730, 330);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nro_cta_corriente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.x_nombre_completo_cheque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x_tasas_interes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x_cod_auth_cheque);
            this.Controls.Add(this.lbl_x_numero_cheque);
            this.Controls.Add(this.x_numero_cheque);
            this.Controls.Add(this.x_banco_cheque);
            this.Controls.Add(this.lbl_info_cheque);
            this.Controls.Add(this.lbl_x_banco_cheque);
            this.Controls.Add(this.x_mes_cheque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x_monto);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.x_anio_cheque);
            this.Controls.Add(this.x_dia_cheque);
            this.Controls.Add(this.lbl_fecha_cheque);
            this.Controls.Add(this.lbl_rut_cheque);
            this.Controls.Add(this.rut_cheque);
            this.Controls.Add(this.cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 200);
            this.Name = "ViewFormCheque";
            this.Text = "ViewFormCheque";
            this.Load += new System.EventHandler(this.ViewFormCheque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label lbl_rut_cheque;
        private System.Windows.Forms.Label lbl_fecha_cheque;
        private System.Windows.Forms.ComboBox x_dia_cheque;
        private System.Windows.Forms.ComboBox x_anio_cheque;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x_monto;
        private System.Windows.Forms.ComboBox x_mes_cheque;
        private System.Windows.Forms.Label lbl_x_banco_cheque;
        private System.Windows.Forms.Label lbl_info_cheque;
        private System.Windows.Forms.TextBox rut_cheque;
        private System.Windows.Forms.ComboBox x_banco_cheque;
        private System.Windows.Forms.TextBox x_numero_cheque;
        private System.Windows.Forms.Label lbl_x_numero_cheque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x_cod_auth_cheque;
        private System.Windows.Forms.TextBox x_tasas_interes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x_nombre_completo_cheque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nro_cta_corriente;
    }
}