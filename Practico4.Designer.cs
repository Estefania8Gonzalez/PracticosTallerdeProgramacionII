namespace Trabajo4
{
    partial class FPractico4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Ldesde = new System.Windows.Forms.Label();
            this.Lhasta = new System.Windows.Forms.Label();
            this.Llistnum = new System.Windows.Forms.Label();
            this.Tdesde = new System.Windows.Forms.TextBox();
            this.Thasta = new System.Windows.Forms.TextBox();
            this.LBlistnum = new System.Windows.Forms.ListBox();
            this.Bgenerar = new System.Windows.Forms.Button();
            this.Bpar = new System.Windows.Forms.Button();
            this.Bimpar = new System.Windows.Forms.Button();
            this.Bprimo = new System.Windows.Forms.Button();
            this.CHgrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PFormulario = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CHgrafico)).BeginInit();
            this.PFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ldesde
            // 
            this.Ldesde.AutoSize = true;
            this.Ldesde.BackColor = System.Drawing.Color.Transparent;
            this.Ldesde.ForeColor = System.Drawing.SystemColors.Control;
            this.Ldesde.Location = new System.Drawing.Point(18, 22);
            this.Ldesde.Name = "Ldesde";
            this.Ldesde.Size = new System.Drawing.Size(38, 13);
            this.Ldesde.TabIndex = 0;
            this.Ldesde.Text = "Desde";
            // 
            // Lhasta
            // 
            this.Lhasta.AutoSize = true;
            this.Lhasta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lhasta.Location = new System.Drawing.Point(18, 51);
            this.Lhasta.Name = "Lhasta";
            this.Lhasta.Size = new System.Drawing.Size(35, 13);
            this.Lhasta.TabIndex = 1;
            this.Lhasta.Text = "Hasta";
            // 
            // Llistnum
            // 
            this.Llistnum.AutoSize = true;
            this.Llistnum.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llistnum.Location = new System.Drawing.Point(289, 34);
            this.Llistnum.Name = "Llistnum";
            this.Llistnum.Size = new System.Drawing.Size(254, 36);
            this.Llistnum.TabIndex = 2;
            this.Llistnum.Text = "Lista de Números";
            this.Llistnum.Click += new System.EventHandler(this.Llistnum_Click);
            // 
            // Tdesde
            // 
            this.Tdesde.Location = new System.Drawing.Point(62, 22);
            this.Tdesde.Name = "Tdesde";
            this.Tdesde.Size = new System.Drawing.Size(171, 20);
            this.Tdesde.TabIndex = 3;
            // 
            // Thasta
            // 
            this.Thasta.Location = new System.Drawing.Point(62, 51);
            this.Thasta.Name = "Thasta";
            this.Thasta.Size = new System.Drawing.Size(171, 20);
            this.Thasta.TabIndex = 4;
            // 
            // LBlistnum
            // 
            this.LBlistnum.FormattingEnabled = true;
            this.LBlistnum.Location = new System.Drawing.Point(277, 103);
            this.LBlistnum.Name = "LBlistnum";
            this.LBlistnum.Size = new System.Drawing.Size(300, 290);
            this.LBlistnum.TabIndex = 5;
            // 
            // Bgenerar
            // 
            this.Bgenerar.Location = new System.Drawing.Point(137, 113);
            this.Bgenerar.Name = "Bgenerar";
            this.Bgenerar.Size = new System.Drawing.Size(110, 30);
            this.Bgenerar.TabIndex = 6;
            this.Bgenerar.Text = "Generar Función";
            this.Bgenerar.UseVisualStyleBackColor = true;
            this.Bgenerar.Click += new System.EventHandler(this.Bgenerar_Click);
            // 
            // Bpar
            // 
            this.Bpar.Location = new System.Drawing.Point(21, 113);
            this.Bpar.Name = "Bpar";
            this.Bpar.Size = new System.Drawing.Size(110, 30);
            this.Bpar.TabIndex = 7;
            this.Bpar.Text = "Par";
            this.Bpar.UseVisualStyleBackColor = true;
            this.Bpar.Click += new System.EventHandler(this.Bpar_Click);
            // 
            // Bimpar
            // 
            this.Bimpar.Location = new System.Drawing.Point(21, 149);
            this.Bimpar.Name = "Bimpar";
            this.Bimpar.Size = new System.Drawing.Size(110, 30);
            this.Bimpar.TabIndex = 8;
            this.Bimpar.Text = "Impar";
            this.Bimpar.UseVisualStyleBackColor = true;
            this.Bimpar.Click += new System.EventHandler(this.Bimpar_Click);
            // 
            // Bprimo
            // 
            this.Bprimo.Location = new System.Drawing.Point(21, 77);
            this.Bprimo.Name = "Bprimo";
            this.Bprimo.Size = new System.Drawing.Size(110, 30);
            this.Bprimo.TabIndex = 9;
            this.Bprimo.Text = "Primo";
            this.Bprimo.UseVisualStyleBackColor = true;
            this.Bprimo.Click += new System.EventHandler(this.Bprimo_Click);
            // 
            // CHgrafico
            // 
            chartArea1.Name = "Serie";
            this.CHgrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CHgrafico.Legends.Add(legend1);
            this.CHgrafico.Location = new System.Drawing.Point(607, 103);
            this.CHgrafico.Name = "CHgrafico";
            series1.ChartArea = "Serie";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CHgrafico.Series.Add(series1);
            this.CHgrafico.Size = new System.Drawing.Size(300, 290);
            this.CHgrafico.TabIndex = 10;
            this.CHgrafico.Text = "chart1";
            this.CHgrafico.Click += new System.EventHandler(this.chart1_Click);
            // 
            // PFormulario
            // 
            this.PFormulario.AutoScroll = true;
            this.PFormulario.BackColor = System.Drawing.Color.DimGray;
            this.PFormulario.Controls.Add(this.Ldesde);
            this.PFormulario.Controls.Add(this.Lhasta);
            this.PFormulario.Controls.Add(this.Bprimo);
            this.PFormulario.Controls.Add(this.Tdesde);
            this.PFormulario.Controls.Add(this.Bimpar);
            this.PFormulario.Controls.Add(this.Thasta);
            this.PFormulario.Controls.Add(this.Bpar);
            this.PFormulario.Controls.Add(this.Bgenerar);
            this.PFormulario.Location = new System.Drawing.Point(12, 103);
            this.PFormulario.Name = "PFormulario";
            this.PFormulario.Size = new System.Drawing.Size(259, 193);
            this.PFormulario.TabIndex = 11;
            this.PFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.PFormulario_Paint);
            // 
            // FPractico4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.PFormulario);
            this.Controls.Add(this.CHgrafico);
            this.Controls.Add(this.LBlistnum);
            this.Controls.Add(this.Llistnum);
            this.Name = "FPractico4";
            this.Text = "Formulario IV";
            ((System.ComponentModel.ISupportInitialize)(this.CHgrafico)).EndInit();
            this.PFormulario.ResumeLayout(false);
            this.PFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ldesde;
        private System.Windows.Forms.Label Lhasta;
        private System.Windows.Forms.Label Llistnum;
        private System.Windows.Forms.TextBox Tdesde;
        private System.Windows.Forms.TextBox Thasta;
        private System.Windows.Forms.ListBox LBlistnum;
        private System.Windows.Forms.Button Bgenerar;
        private System.Windows.Forms.Button Bpar;
        private System.Windows.Forms.Button Bimpar;
        private System.Windows.Forms.Button Bprimo;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHgrafico;
        private System.Windows.Forms.Panel PFormulario;
    }
}

