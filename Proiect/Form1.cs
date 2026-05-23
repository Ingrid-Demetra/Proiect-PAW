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
        private MaterieRepository _materieRepo = new MaterieRepository();
        private SalaRepository _salaRepo = new SalaRepository();
        public Form1()
        {
            InitializeComponent();
            IncarcaProfesori();
            IncarcaMaterii();
            IncarcaSali();
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
        private void IncarcaMaterii()
        {
            dgvMaterii.DataSource = null;
            dgvMaterii.DataSource = _materieRepo.GetAll();
        }
        private void btnAdaugaMaterie_Click(object sender, EventArgs e)
        {
            using (FormMaterie f = new FormMaterie(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _materieRepo.Add(f.MaterieModificata);
                    IncarcaMaterii();
                }
            }
        }

        private void btnEditeazaMaterie_Click(object sender, EventArgs e)
        {
            if (dgvMaterii.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o materie!");
                return;
            }

            Materie selectata = (Materie)dgvMaterii.SelectedRows[0].DataBoundItem;

            using (FormMaterie f = new FormMaterie(selectata))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _materieRepo.Update(f.MaterieModificata);
                    IncarcaMaterii();
                }
            }
        }

        private void btnStergeMaterie_Click(object sender, EventArgs e)
        {
            if (dgvMaterii.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o materie!");
                return;
            }

            Materie selectata = (Materie)dgvMaterii.SelectedRows[0].DataBoundItem;

            var confirmare = MessageBox.Show("Sigur stergi?", "Confirmare", MessageBoxButtons.YesNo);
            if (confirmare == DialogResult.Yes)
            {
                _materieRepo.Delete(selectata.ID);
                IncarcaMaterii();
            }
        }
        private void IncarcaSali()
        {
            dgvSali.DataSource = null;
            dgvSali.DataSource = _salaRepo.GetAll();
        }
        private void btnAdaugaSala_Click(object sender, EventArgs e)
        {
            using (FormSala f = new FormSala(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _salaRepo.Add(f.SalaModificata);
                    IncarcaSali();
                }
            }
        }

        private void btnEditeazaSala_Click(object sender, EventArgs e)
        {
            if (dgvSali.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o sala!");
                return;
            }

            Sala selectata = (Sala)dgvSali.SelectedRows[0].DataBoundItem;

            using (FormSala f = new FormSala(selectata))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _salaRepo.Update(f.SalaModificata);
                    IncarcaSali();
                }
            }
        }

        private void btnStergeSala_Click(object sender, EventArgs e)
        {
            if (dgvSali.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o sala!");
                return;
            }

            Sala selectata = (Sala)dgvSali.SelectedRows[0].DataBoundItem;

            var confirmare = MessageBox.Show("Sigur stergi?", "Confirmare", MessageBoxButtons.YesNo);
            if (confirmare == DialogResult.Yes)
            {
                _salaRepo.Delete(selectata.ID);
                IncarcaSali();
            }
        }
    }
}
