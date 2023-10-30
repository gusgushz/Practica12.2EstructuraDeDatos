using Practica12._2.Entities;

namespace Practica12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Estacionamiento gus = new Estacionamiento();
        private void button1_Click(object sender, EventArgs e)
        {
            string propietario = textBox1.Text;
            string placas = textBox2.Text;
            if (!string.IsNullOrEmpty(propietario) && !string.IsNullOrWhiteSpace(propietario) || !string.IsNullOrEmpty(placas) && !string.IsNullOrWhiteSpace(placas))
            {
                Auto agregado = gus.AgregarAutos(propietario, placas);
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = agregado.Propietario;
                dataGridView1.Rows[n].Cells[1].Value = agregado.Placas;
                dataGridView1.Rows[n].Cells[2].Value = agregado.HoraEntrada;

                MessageBox.Show($"Auto con placas: {agregado.Placas} \nPropietario: {agregado.Propietario}", "AUTO AGREGADO AL ESTACIONAMIENTO");
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int n = dataGridView1.FirstDisplayedScrollingRowIndex;
                dataGridView1.Rows.RemoveAt(n);
                Auto borrado = gus.SacarAutos();
                MessageBox.Show($"Auto con placas:{borrado.Placas}\nPropietario: {borrado.Propietario}\nTiempo Transcurrido: {borrado.TiempoTranscurrido}\nTotal por pagar: ${borrado.CostoEstacionamiento}" , "AUTO SALE DEL ESTACIONAMIENTO");
            }
            else
            {
                MessageBox.Show("El estacionamiento está vacío", "ESTACIONAMIENTO VACIO");
            }
        }
    }
}