
namespace Graficos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xValor = new System.Windows.Forms.TextBox();
            this.yValor = new System.Windows.Forms.TextBox();
            this.btnInserirValores = new System.Windows.Forms.Button();
            this.dataValores = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tipoGrafico = new System.Windows.Forms.ComboBox();
            this.grafico3D = new System.Windows.Forms.CheckBox();
            this.palleteCor = new System.Windows.Forms.ComboBox();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico
            // 
            chartArea3.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafico.Legends.Add(legend3);
            this.grafico.Location = new System.Drawing.Point(358, 12);
            this.grafico.Name = "grafico";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "X vs Y";
            this.grafico.Series.Add(series3);
            this.grafico.Size = new System.Drawing.Size(579, 426);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gráfico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor de X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor de Y";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xValor
            // 
            this.xValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValor.Location = new System.Drawing.Point(12, 88);
            this.xValor.Name = "xValor";
            this.xValor.Size = new System.Drawing.Size(157, 31);
            this.xValor.TabIndex = 4;
            this.xValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xValor_KeyPress);
            // 
            // yValor
            // 
            this.yValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValor.Location = new System.Drawing.Point(180, 88);
            this.yValor.Name = "yValor";
            this.yValor.Size = new System.Drawing.Size(157, 31);
            this.yValor.TabIndex = 5;
            this.yValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yValor_KeyPress);
            // 
            // btnInserirValores
            // 
            this.btnInserirValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirValores.Location = new System.Drawing.Point(12, 125);
            this.btnInserirValores.Name = "btnInserirValores";
            this.btnInserirValores.Size = new System.Drawing.Size(325, 44);
            this.btnInserirValores.TabIndex = 18;
            this.btnInserirValores.Text = "Inserir Valores no Gráfico";
            this.btnInserirValores.UseVisualStyleBackColor = true;
            this.btnInserirValores.Click += new System.EventHandler(this.btnInserirValores_Click);
            // 
            // dataValores
            // 
            this.dataValores.AllowUserToAddRows = false;
            this.dataValores.AllowUserToDeleteRows = false;
            this.dataValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataValores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataValores.Location = new System.Drawing.Point(12, 175);
            this.dataValores.MultiSelect = false;
            this.dataValores.Name = "dataValores";
            this.dataValores.ReadOnly = true;
            this.dataValores.RowHeadersVisible = false;
            this.dataValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataValores.Size = new System.Drawing.Size(325, 213);
            this.dataValores.TabIndex = 20;
            this.dataValores.SelectionChanged += new System.EventHandler(this.dataValores_SelectionChanged);
            // 
            // x
            // 
            this.x.HeaderText = "Eixo X";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // y
            // 
            this.y.HeaderText = "Eixo Y";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 394);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(325, 44);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar Gráfico";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tipoGrafico
            // 
            this.tipoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoGrafico.FormattingEnabled = true;
            this.tipoGrafico.Location = new System.Drawing.Point(10, 457);
            this.tipoGrafico.Name = "tipoGrafico";
            this.tipoGrafico.Size = new System.Drawing.Size(324, 28);
            this.tipoGrafico.TabIndex = 22;
            this.tipoGrafico.SelectedIndexChanged += new System.EventHandler(this.tipoGrafico_SelectedIndexChanged);
            // 
            // grafico3D
            // 
            this.grafico3D.AutoSize = true;
            this.grafico3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grafico3D.Location = new System.Drawing.Point(670, 457);
            this.grafico3D.Name = "grafico3D";
            this.grafico3D.Size = new System.Drawing.Size(105, 24);
            this.grafico3D.TabIndex = 23;
            this.grafico3D.Text = "Gráfico 3D";
            this.grafico3D.UseVisualStyleBackColor = true;
            this.grafico3D.CheckedChanged += new System.EventHandler(this.grafico3D_CheckedChanged);
            // 
            // palleteCor
            // 
            this.palleteCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palleteCor.FormattingEnabled = true;
            this.palleteCor.Location = new System.Drawing.Point(340, 457);
            this.palleteCor.Name = "palleteCor";
            this.palleteCor.Size = new System.Drawing.Size(324, 28);
            this.palleteCor.TabIndex = 24;
            this.palleteCor.SelectedIndexChanged += new System.EventHandler(this.palleteCor_SelectedIndexChanged);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorio.Location = new System.Drawing.Point(781, 449);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(156, 44);
            this.btnAleatorio.TabIndex = 25;
            this.btnAleatorio.Text = "Inserir Valores Aleatorios";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 497);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.palleteCor);
            this.Controls.Add(this.grafico3D);
            this.Controls.Add(this.tipoGrafico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataValores);
            this.Controls.Add(this.btnInserirValores);
            this.Controls.Add(this.yValor);
            this.Controls.Add(this.xValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grafico);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xValor;
        private System.Windows.Forms.TextBox yValor;
        private System.Windows.Forms.Button btnInserirValores;
        private System.Windows.Forms.DataGridView dataValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox tipoGrafico;
        private System.Windows.Forms.CheckBox grafico3D;
        private System.Windows.Forms.ComboBox palleteCor;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Timer timer;
    }
}

