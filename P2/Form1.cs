using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mahasiswaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mahasiswaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prodiTIDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet.Nilai);
            // TODO: This line of code loads data into the 'prodiTIDataSet.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.prodiTIDataSet.MataKuliah);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Periode' table. You can move, or remove it, as needed.
            this.periodeTableAdapter.Fill(this.prodiTIDataSet.Periode);
            // TODO: This line of code loads data into the 'prodiTIDataSet.UserMhs' table. You can move, or remove it, as needed.
            this.userMhsTableAdapter.Fill(this.prodiTIDataSet.UserMhs);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mahasiswaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void mahasiswaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
