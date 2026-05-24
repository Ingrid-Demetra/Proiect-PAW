using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


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
            SeteazaStilDgv(dgvProfesori);
            SeteazaStilDgv(dgvMaterii);
            SeteazaStilDgv(dgvSali);
            SeteazaStilDgv(dgvOrar);
            IncarcaProfesori();
            IncarcaMaterii();
            IncarcaSali();
            IncarcaOre();
        }
        
        private void IncarcaProfesori()
        {
            dgvProfesori.DataSource = null;
            dgvProfesori.DataSource = _profesorRepo.GetAll();
            dgvProfesori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvMaterii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvSali.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvOrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (var ora in ore)
            {
                ora.Profesor = profesori.FirstOrDefault(p => p.ID == ora.ProfesorID);
                ora.Materie = materii.FirstOrDefault(m => m.ID == ora.MaterieID);
                ora.Sala = sali.FirstOrDefault(s => s.ID == ora.SalaID);
            }
            var ordineSaptamana = new List<string> { "Luni", "Marti", "Miercuri", "Joi", "Vineri" };
            ore = ore.OrderBy(o => ordineSaptamana.IndexOf(o.Zi)).ToList();

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
                MessageBox.Show("Selectati un rand!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Selectati un rand!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void printeazaOrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintOrar;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }
        private void PrintOrar(object sender, PrintPageEventArgs e)
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

            var zile = new List<string> { "Luni", "Marti", "Miercuri", "Joi", "Vineri" };
            var intervale = ore.Select(o => o.OraInceput + "-" + o.OraSfarsit).Distinct().OrderBy(x => x).ToList();

            Font fontTitlu = new Font("Arial", 14, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 9, FontStyle.Bold);
            Font fontDate = new Font("Arial", 8);

            int startX = 40;
            int startY = 40;
            int latimeInterval = 80;
            int latimeZi = 100;
            int inaltimeLinie = 50;

           
            e.Graphics.DrawString("Orar Profesori", fontTitlu, Brushes.Black, startX, startY);
            startY += 35;

            
            e.Graphics.FillRectangle(Brushes.SteelBlue, startX, startY, latimeInterval, inaltimeLinie);
            e.Graphics.DrawString("Interval", fontHeader, Brushes.White, startX + 5, startY + 15);

            for (int i = 0; i < zile.Count; i++)
            {
                int x = startX + latimeInterval + i * latimeZi;
                e.Graphics.FillRectangle(Brushes.SteelBlue, x, startY, latimeZi, inaltimeLinie);
                e.Graphics.DrawString(zile[i], fontHeader, Brushes.White, x + 25, startY + 15);
            }

            startY += inaltimeLinie;

            
            foreach (var interval in intervale)
            {
                
                e.Graphics.DrawRectangle(Pens.Gray, startX, startY, latimeInterval, inaltimeLinie);
                e.Graphics.DrawString(interval, fontHeader, Brushes.Black, startX + 5, startY + 15);

              
                for (int i = 0; i < zile.Count; i++)
                {
                    int x = startX + latimeInterval + i * latimeZi;
                    e.Graphics.DrawRectangle(Pens.Gray, x, startY, latimeZi, inaltimeLinie);

                    var ora = ore.FirstOrDefault(o => o.Zi == zile[i] &&
                              o.OraInceput + "-" + o.OraSfarsit == interval);

                    if (ora != null)
                    {
                        e.Graphics.DrawString(ora.NumeMaterie, fontDate, Brushes.Black, x + 3, startY + 5);
                        e.Graphics.DrawString(ora.NumeProfesor, fontDate, Brushes.Black, x + 3, startY + 20);
                        e.Graphics.DrawString("Sala " + ora.NumarSalaAfisare, fontDate, Brushes.Black, x + 3, startY + 35);
                    }
                }

                startY += inaltimeLinie;
            }
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
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

            if (cmbFiltruZi.SelectedItem != null && cmbFiltruZi.SelectedItem.ToString() != "Toate")
            {
                ore = ore.Where(o => o.Zi == cmbFiltruZi.SelectedItem.ToString()).ToList();
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
        }

        private void SeteazaStilDgv(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.RowTemplate.Height = 30;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
        }

    }
}
