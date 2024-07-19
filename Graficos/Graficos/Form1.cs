using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos
{
    public partial class Form1 : Form
    {
        Dictionary<double, double> valores;
        int contadorX = 0;

        public Form1()
        {
            InitializeComponent();
            valores = new Dictionary<double, double>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xValor.Focus();

            for (int i = 0; i < 35; i++)
            {
                tipoGrafico.Items.Add((SeriesChartType)i);
            }

            for (int i = 0; i < 13; i++)
            {
                palleteCor.Items.Add((ChartColorPalette)i);
            }
        }

        private void btnInserirValores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(xValor.Text) || string.IsNullOrEmpty(yValor.Text))
            {
                MessageBox.Show("Os dois valores são obrigatórios");
                return;
            }

            if (valores.ContainsKey(double.Parse(xValor.Text)))
            {
                valores[double.Parse(xValor.Text)] = double.Parse(yValor.Text);
            }
            else
            {
                valores.Add(double.Parse(xValor.Text), double.Parse(yValor.Text));
            }

            var items = from valor in valores orderby valor.Key ascending select valor;

            dataValores.Rows.Clear();
            grafico.Series[0].Points.Clear();

            foreach (var item in items)
            {
                dataValores.Rows.Add(item.Key, item.Value);
                grafico.Series[0].Points.AddXY(item.Key, item.Value);
            }

            grafico.Update();

            xValor.Text = "";
            yValor.Text = "";
            xValor.Focus();
        }

        private void dataValores_SelectionChanged(object sender, EventArgs e)
        {
            xValor.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[0].Value.ToString();
            yValor.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            valores.Clear();
            grafico.Series[0].Points.Clear();
            dataValores.Rows.Clear();
            contadorX = 0;
            xValor.Text = "";
            yValor.Text = "";
            xValor.Focus();
        }

        private void tipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Series[0].ChartType = (SeriesChartType)tipoGrafico.SelectedItem;
        }

        private void palleteCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Palette = (ChartColorPalette)palleteCor.SelectedItem;
        }

        private void grafico3D_CheckedChanged(object sender, EventArgs e)
        {
            grafico.ChartAreas[0].Area3DStyle.Enable3D = grafico3D.Checked;
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void xValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (xValor.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void yValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (yValor.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (grafico.Series[0].Points.Count() > 10)
            {
                grafico.Series[0].Points.RemoveAt(0);
                grafico.Update();
            }

            double y = (double)new Random((int)DateTime.Now.Ticks).Next(1000);

            grafico.Series[0].Points.AddXY(contadorX++, y);
            dataValores.Rows.Add(contadorX, y);
            dataValores.CurrentCell = dataValores.Rows[dataValores.Rows.Count - 1].Cells[0];
        }
    }
}
