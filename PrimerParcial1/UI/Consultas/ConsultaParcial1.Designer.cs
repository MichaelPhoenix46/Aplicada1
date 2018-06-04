namespace PrimerParcial1.UI.Consultas
{
    partial class ConsultaParcial1
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
            this.FiltroId = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CriterioTexto = new System.Windows.Forms.TextBox();
            this.criterio = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.RangoFecha = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BotonImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroId
            // 
            this.FiltroId.AutoSize = true;
            this.FiltroId.Location = new System.Drawing.Point(49, 33);
            this.FiltroId.Name = "FiltroId";
            this.FiltroId.Size = new System.Drawing.Size(39, 17);
            this.FiltroId.TabIndex = 0;
            this.FiltroId.Text = "Filtro";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // CriterioTexto
            // 
            this.CriterioTexto.Location = new System.Drawing.Point(311, 33);
            this.CriterioTexto.Name = "CriterioTexto";
            this.CriterioTexto.Size = new System.Drawing.Size(232, 22);
            this.CriterioTexto.TabIndex = 2;
            // 
            // criterio
            // 
            this.criterio.AutoSize = true;
            this.criterio.Location = new System.Drawing.Point(252, 33);
            this.criterio.Name = "criterio";
            this.criterio.Size = new System.Drawing.Size(53, 17);
            this.criterio.TabIndex = 3;
            this.criterio.Text = "Criterio";
            this.criterio.Click += new System.EventHandler(this.criterio_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BotonBuscar.Location = new System.Drawing.Point(549, 20);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(97, 43);
            this.BotonBuscar.TabIndex = 4;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // RangoFecha
            // 
            this.RangoFecha.AutoSize = true;
            this.RangoFecha.Location = new System.Drawing.Point(24, 68);
            this.RangoFecha.Name = "RangoFecha";
            this.RangoFecha.Size = new System.Drawing.Size(208, 17);
            this.RangoFecha.TabIndex = 5;
            this.RangoFecha.Text = "Filtrar Usando Rango De Fecha";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(238, 68);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(49, 17);
            this.Desde.TabIndex = 6;
            this.Desde.Text = "Desde";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(484, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(686, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // BotonImprimir
            // 
            this.BotonImprimir.Location = new System.Drawing.Point(27, 308);
            this.BotonImprimir.Name = "BotonImprimir";
            this.BotonImprimir.Size = new System.Drawing.Size(93, 45);
            this.BotonImprimir.TabIndex = 10;
            this.BotonImprimir.Text = "Imprimir";
            this.BotonImprimir.UseVisualStyleBackColor = true;
            // 
            // ConsultaParcial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 355);
            this.Controls.Add(this.BotonImprimir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.RangoFecha);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.criterio);
            this.Controls.Add(this.CriterioTexto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FiltroId);
            this.Name = "ConsultaParcial1";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FiltroId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox CriterioTexto;
        private System.Windows.Forms.Label criterio;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Label RangoFecha;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BotonImprimir;
    }
}