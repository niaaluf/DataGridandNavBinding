using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Binding
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 7, FontStyle.Bold);

            dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;

            dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;

            dataGridView1.Columns[2].HeaderText = "Alamat Mahasiswa";
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.LightSeaGreen;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;

            dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[4].HeaderText = "No. Telpon";
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.label7.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f5.label8.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f5.label9.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f5.label10.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f5.label11.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}
