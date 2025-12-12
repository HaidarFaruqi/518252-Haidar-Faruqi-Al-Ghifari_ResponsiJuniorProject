using System;
using System.Windows.Forms;

namespace Responsi
{
    public partial class Form1 : Form
    {
        private readonly DeveloperRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new DeveloperRepository();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProyek();
            LoadDeveloper();
        }
        private void LoadProyek()
        {
            cb_proyek.DataSource = _repository.GetAllproyek();
            cb_proyek.DisplayMember = "Nama Proyek";
            cb_proyek.ValueMember = "IdProyek";
        }

        private void LoadDeveloper()
        {

            dg_performa.DataSource = _repository.GetAllDeveloper();
        }

        private void dg_performa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            var developer = new developer
            {
                nama = tb_dev.Text,
                status = cb_kontrak.Text,
                fitur = tb_kinerja.Text,
                bug = tb_bug.Text,
                idProyek = cb_proyek.Text
            };
            LoadDeveloper();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (dg_performa.CurrentRow == null) return;
            var developerEdit = new developer
            {
                idDeveloper = (int)dg_performa.CurrentRow.Cells["idDeveloper"].Value,
                nama = tb_dev.Text.Trim(),
                status = cb_kontrak.Text,
                fitur = tb_kinerja.Text,
                bug = tb_bug.Text,
                idProyek = cb_proyek.Text
            };
            _repository.Update(developerEdit);
            LoadDeveloper();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if(dg_performa.CurrentRow == null) return;
            int id = (int)dg_performa.CurrentRow.Cells["idDeveloper"].Value;
            _repository.Delete(id);
            LoadDeveloper();
        }
    }
}