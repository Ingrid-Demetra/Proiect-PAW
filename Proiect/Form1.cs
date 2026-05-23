using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        private ProfesorRepository _profesorRepo = new ProfesorRepository();
        public Form1()
        {
            InitializeComponent();
            IncarcaProfesori();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            IncarcaProfesori();
        }

        private void IncarcaProfesori()
        {
            dgvProfesori.DataSource = null;
            dgvProfesori.DataSource = _profesorRepo.GetAll();
        }

        private void btnAdaugaProfesor_Click(object sender, EventArgs e)
        {
            using (FormProfesor f = new FormProfesor(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _profesorRepo.Add(f.ProfesorModificat);
                    IncarcaProfesori();
                }
            }
        }

        private void btnEditeazaProfesor_Click(object sender, EventArgs e)
        {
            if (dgvProfesori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un profesor!");
                return;
            }

            Profesor selectat = (Profesor)dgvProfesori.SelectedRows[0].DataBoundItem;

            using (FormProfesor f = new FormProfesor(selectat))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _profesorRepo.Update(f.ProfesorModificat);
                    IncarcaProfesori();
                }
            }
        }

        private void btnStergeProfesor_Click(object sender, EventArgs e)
        {
            if (dgvProfesori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati un profesor!");
                return;
            }

            Profesor selectat = (Profesor)dgvProfesori.SelectedRows[0].DataBoundItem;

            var confirmare = MessageBox.Show("Sigur stergi?", "Confirmare", MessageBoxButtons.YesNo);
            if (confirmare == DialogResult.Yes)
            {
                _profesorRepo.Delete(selectat.ID);
                IncarcaProfesori();
            }
        }
    }
}
