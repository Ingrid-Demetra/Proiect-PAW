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
    public partial class FormSala : Form
    {
        public Sala SalaModificata { get; private set; }
        private Sala _salaExistenta;

        public FormSala(Sala sala)
        {
            InitializeComponent();
            _salaExistenta = sala;

            if (sala != null)
            {
                nudNumarSala.Value = sala.NumarSala;
                nudCapacitate.Value = sala.Capacitate;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            bool valid = true;
            errorProviderSali.Clear();

            if (nudNumarSala.Value <= 0)
            {
                errorProviderSali.SetError(nudNumarSala, "Numarul salii este obligatoriu!");
                valid = false;
            }

            if (nudCapacitate.Value <= 0)
            {
                errorProviderSali.SetError(nudCapacitate, "Capacitatea este obligatorie!");
                valid = false;
            }

            if (!valid) return;

            SalaModificata = new Sala
            {
                ID = _salaExistenta != null ? _salaExistenta.ID : 0,
                NumarSala = (int)nudNumarSala.Value,
                Capacitate = (int)nudCapacitate.Value
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
