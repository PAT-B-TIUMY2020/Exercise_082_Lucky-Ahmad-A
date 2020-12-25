using Service_082_Lucky_Ahmad_A;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_082_Lucky_Ahmad_A
{
    public partial class Form1 : Form
    {
        ClassData data = new ClassData();
        public Form1()
        {
            InitializeComponent();
        }
        public void TampilData()
        {
           /* var List = data.getAllData();
            dataGridView1.DataSource = List;*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*string nim = textBoxNIM.Text;
            string nama = textBoxNama.Text;
            string prodi = textBoxProdi.Text;
            string angkatan = textBoxAngkatan.Text;
            data.insertMahasiswa(nim, nama, prodi, angkatan);
            Clear();
            dataGridView1.DataSource = data.getAllData();*/
        }
        private void Clear()
        {
            textBoxNIM.Clear();
            textBoxNama.Clear();
            textBoxProdi.Clear();
            textBoxAngkatan.Clear();

            textBoxNIM.Enabled = true;

            buttonInsert.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* dataGridView1.DataSource = data.getAllData();
            TampilData();

            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;*/
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            /*ClassData classData = new ClassData();
            classData.deleteMahasiswa(textBoxNIM.Text);
            Clear();
            dataGridView1.DataSource = classData.getAllData();*/
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            /*Mahasiswa mhs = new Mahasiswa();
            mhs.nim = textBoxNIM.Text;
            mhs.nama = textBoxNama.Text;
            mhs.prodi = textBoxProdi.Text;
            mhs.angkatan = textBoxAngkatan.Text;

            ClassData classData = new ClassData();
            classData.updateDatabase(mhs);
            Clear();
            dataGridView1.DataSource = classData.getAllData();*/
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          /*  if (textBoxNIM.Text != "")
            {
                string nim = textBoxNIM.Text;
                List<Mahasiswa> mhs = new List<Mahasiswa>();
                mhs.Add(data.search(nim));
                Clear();
                dataGridView1.DataSource = mhs;
            }
            else
            {
                dataGridView1.DataSource = data.getAllData();
            }*/
        }

        private void buttonJumlah_Click(object sender, EventArgs e)
        {
            /*var jmlh = data.Jumlahdata();
            label7.Text = jmlh;*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNIM.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            textBoxNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBoxProdi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            textBoxAngkatan.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            buttonInsert.Enabled = false;
        }
    }
}
