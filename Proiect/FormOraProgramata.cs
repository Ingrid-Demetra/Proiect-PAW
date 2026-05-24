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
    public partial class FormOraProgramata : Form
    {
        public OraProgramata OraModificata { get; private set; }
        private OraProgramata _oraExistenta;

        private ProfesorRepository _profesorRepo = new ProfesorRepository();
        private MaterieRepository _materieRepo = new MaterieRepository();
        private SalaRepository _salaRepo = new SalaRepository();

        public FormOraProgramata(OraProgramata ora)
        {
            InitializeComponent();
            _oraExistenta = ora;

            IncarcaComboBoxuri();

            if (ora != null)
            {
                cmbProfesor.SelectedValue = ora.ProfesorID;
                cmbMaterie.SelectedValue = ora.MaterieID;
                cmbSala.SelectedValue = ora.SalaID;
                cmbZi.SelectedItem = ora.Zi;
                txtOraInceput.Text = ora.OraInceput;
                txtOraSfarsit.Text = ora.OraSfarsit;
            }
        }

        private void IncarcaComboBoxuri()
        {
            // Profesori
            cmbProfesor.DataSource = _profesorRepo.GetAll();
            cmbProfesor.DisplayMember = "Nume";
            cmbProfesor.ValueMember = "ID";

            // Materii
            cmbMaterie.DataSource = _materieRepo.GetAll();
            cmbMaterie.DisplayMember = "Denumire";
            cmbMaterie.ValueMember = "ID";

            // Sali
            cmbSala.DataSource = _salaRepo.GetAll();
            cmbSala.DisplayMember = "NumarSala";
            cmbSala.ValueMember = "ID";

            // Zile
            cmbZi.Items.AddRange(new string[] { "Luni", "Marti", "Miercuri", "Joi", "Vineri" });
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            bool valid = true;
            errorProvider.Clear();

            if (cmbProfesor.SelectedValue == null)
            {
                errorProvider.SetError(cmbProfesor, "Selectati un profesor!");
                valid = false;
            }

            if (cmbMaterie.SelectedValue == null)
            {
                errorProvider.SetError(cmbMaterie, "Selectati o materie!");
                valid = false;
            }

            if (cmbSala.SelectedValue == null)
            {
                errorProvider.SetError(cmbSala, "Selectati o sala!");
                valid = false;
            }

            if (cmbZi.SelectedItem == null)
            {
                errorProvider.SetError(cmbZi, "Selectati o zi!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtOraInceput.Text))
            {
                errorProvider.SetError(txtOraInceput, "Ora de inceput este obligatorie!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtOraSfarsit.Text))
            {
                errorProvider.SetError(txtOraSfarsit, "Ora de sfarsit este obligatorie!");
                valid = false;
            }

            if (!valid) return;

            OraModificata = new OraProgramata
            {
                ID = _oraExistenta != null ? _oraExistenta.ID : 0,
                ProfesorID = (int)cmbProfesor.SelectedValue,
                MaterieID = (int)cmbMaterie.SelectedValue,
                SalaID = (int)cmbSala.SelectedValue,
                Zi = cmbZi.SelectedItem.ToString(),
                OraInceput = txtOraInceput.Text,
                OraSfarsit = txtOraSfarsit.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

