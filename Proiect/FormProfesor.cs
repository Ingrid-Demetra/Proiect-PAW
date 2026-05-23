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
    public partial class FormProfesor : Form
    {
        public Profesor ProfesorModificat { get; private set; }
        private Profesor _profesorExistent;

        public FormProfesor (Profesor profesor)
        {
            InitializeComponent();
            _profesorExistent = profesor;

            if (profesor != null)
            {
                // Editare - precompletam campurile
                txtNume.Text = profesor.Nume;
                txtPrenume.Text = profesor.Prenume;
                txtCatedra.Text = profesor.Catedra;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) ||
                string.IsNullOrWhiteSpace(txtPrenume.Text) ||
                string.IsNullOrWhiteSpace(txtCatedra.Text))
            {
                MessageBox.Show("Completati toate campurile!");
                return;
            }

            ProfesorModificat = new Profesor
            {
                ID = _profesorExistent != null ? _profesorExistent.ID : 0,
                Nume = txtNume.Text,
                Prenume = txtPrenume.Text,
                Catedra = txtCatedra.Text
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
