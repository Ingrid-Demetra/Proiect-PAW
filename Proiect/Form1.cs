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
        private OraProgramataRepository _oraRepo = new OraProgramataRepository();

        public Form1()
        {
            InitializeComponent();
            IncarcaProfesori();
            IncarcaMaterii();
            IncarcaSali();
            IncarcaOre();
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
                MessageBox.Show("Selectati un profesor!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Selectati un profesor!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Profesor selectat = (Profesor)dgvProfesori.SelectedRows[0].DataBoundItem;

            var confirmare = MessageBox.Show("Sigur doriti sa stergeti?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show("Selectati o materie!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Selectati o materie!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Selectati o sala!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Selectati o sala!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sala selectata = (Sala)dgvSali.SelectedRows[0].DataBoundItem;

            var confirmare = MessageBox.Show("Sigur doriti sa stergeti?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmare == DialogResult.Yes)
            {
                _salaRepo.Delete(selectata.ID);
                IncarcaSali();
            }
        }
        private void IncarcaOre()
        {
            var ore = _oraRepo.GetAll();
            var profesori = _profesorRepo.GetAll();
            var materii = _materieRepo.GetAll();
            var sali = _salaRepo.GetAll();

            foreach (var ora in ore)
            {
                ora.Profesor = profesori.FirstOrDefault(p => p.ID == ora.ProfesorID);
                ora.Materie = materii.FirstOrDefault(m => m.ID == ora.MaterieID);
                ora.Sala = sali.FirstOrDefault(s => s.ID == ora.SalaID);
            }

            dgvOrar.DataSource = null;
            dgvOrar.DataSource = ore;

            dgvOrar.Columns["ID"].Visible = false;
            dgvOrar.Columns["ProfesorID"].Visible = false;
            dgvOrar.Columns["MaterieID"].Visible = false;
            dgvOrar.Columns["SalaID"].Visible = false;
            dgvOrar.Columns["Profesor"].Visible = false;
            dgvOrar.Columns["Materie"].Visible = false;
            dgvOrar.Columns["Sala"].Visible = false;

            dgvOrar.Columns["NumeProfesor"].HeaderText = "Profesor";
            dgvOrar.Columns["NumeMaterie"].HeaderText = "Materie";
            dgvOrar.Columns["NumarSalaAfisare"].HeaderText = "Sala";

        }

        private void btnAdaugaOrar_Click(object sender, EventArgs e)
        {
            using (FormOraProgramata f = new FormOraProgramata(null))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _oraRepo.Add(f.OraModificata);
                    IncarcaOre();
                }
            }
        }

        private void btnEditeazaOrar_Click(object sender, EventArgs e)
        {
            if (dgvOrar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o ora!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OraProgramata selectata = (OraProgramata)dgvOrar.SelectedRows[0].DataBoundItem;

            using (FormOraProgramata f = new FormOraProgramata(selectata))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _oraRepo.Update(f.OraModificata);
                    IncarcaOre();
                }
            }
        }

        private void btnStergeOrar_Click(object sender, EventArgs e)
        {
            if (dgvOrar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o ora!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OraProgramata selectata = (OraProgramata)dgvOrar.SelectedRows[0].DataBoundItem;

            var confirmare = MessageBox.Show("Sigur doriti sa stergeti?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmare == DialogResult.Yes)
            {
                _oraRepo.Delete(selectata.ID);
                IncarcaOre();
            }
        }
    }
}
