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
    public partial class FormMaterie : Form
    {
        public Materie MaterieModificata { get; private set; }
        private Materie _materieExistenta;

        public FormMaterie(Materie materie)
        {
            InitializeComponent();
            _materieExistenta = materie;

            if (materie != null)
            {
                txtDenumire.Text = materie.Denumire;
                nudAnStudiu.Value = (decimal) materie.AnStudiu;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            bool valid = true;
            errorProviderMaterie.Clear();

            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                errorProviderMaterie.SetError(txtDenumire, "Denumirea este obligatorie!");
                valid = false;
            }

            if (nudAnStudiu.Value <= 0)
            {
                errorProviderMaterie.SetError(nudAnStudiu, "Anul de studiu trebuie sa fie mai mare ca 0!");
                valid = false;
            }

            if (!valid) return;

            MaterieModificata = new Materie
            {
                ID = _materieExistenta != null ? _materieExistenta.ID : 0,
                Denumire = txtDenumire.Text,
                AnStudiu = (int)nudAnStudiu.Value
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
