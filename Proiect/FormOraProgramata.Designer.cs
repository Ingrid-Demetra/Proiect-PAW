namespace Proiect
{
    partial class FormOraProgramata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.cmbMaterie = new System.Windows.Forms.ComboBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.lblcmbProfesor = new System.Windows.Forms.Label();
            this.lblMaterie = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.cmbZi = new System.Windows.Forms.ComboBox();
            this.lblZi = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtOraInceput = new System.Windows.Forms.TextBox();
            this.txtOraSfarsit = new System.Windows.Forms.TextBox();
            this.lblOraInceput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(41, 42);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(121, 24);
            this.cmbProfesor.TabIndex = 0;
            // 
            // cmbMaterie
            // 
            this.cmbMaterie.FormattingEnabled = true;
            this.cmbMaterie.Location = new System.Drawing.Point(41, 99);
            this.cmbMaterie.Name = "cmbMaterie";
            this.cmbMaterie.Size = new System.Drawing.Size(121, 24);
            this.cmbMaterie.TabIndex = 1;
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(41, 165);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(121, 24);
            this.cmbSala.TabIndex = 2;
            // 
            // lblcmbProfesor
            // 
            this.lblcmbProfesor.AutoSize = true;
            this.lblcmbProfesor.Location = new System.Drawing.Point(38, 23);
            this.lblcmbProfesor.Name = "lblcmbProfesor";
            this.lblcmbProfesor.Size = new System.Drawing.Size(58, 16);
            this.lblcmbProfesor.TabIndex = 3;
            this.lblcmbProfesor.Text = "Profesor";
            // 
            // lblMaterie
            // 
            this.lblMaterie.AutoSize = true;
            this.lblMaterie.Location = new System.Drawing.Point(41, 80);
            this.lblMaterie.Name = "lblMaterie";
            this.lblMaterie.Size = new System.Drawing.Size(52, 16);
            this.lblMaterie.TabIndex = 4;
            this.lblMaterie.Text = "Materie";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(38, 146);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(35, 16);
            this.lblSala.TabIndex = 5;
            this.lblSala.Text = "Sala";
            // 
            // cmbZi
            // 
            this.cmbZi.FormattingEnabled = true;
            this.cmbZi.Location = new System.Drawing.Point(41, 228);
            this.cmbZi.Name = "cmbZi";
            this.cmbZi.Size = new System.Drawing.Size(121, 24);
            this.cmbZi.TabIndex = 6;
            // 
            // lblZi
            // 
            this.lblZi.AutoSize = true;
            this.lblZi.Location = new System.Drawing.Point(41, 209);
            this.lblZi.Name = "lblZi";
            this.lblZi.Size = new System.Drawing.Size(18, 16);
            this.lblZi.TabIndex = 7;
            this.lblZi.Text = "Zi";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(523, 398);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(120, 35);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(663, 398);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(120, 35);
            this.btnAnuleaza.TabIndex = 9;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtOraInceput
            // 
            this.txtOraInceput.Location = new System.Drawing.Point(41, 291);
            this.txtOraInceput.Name = "txtOraInceput";
            this.txtOraInceput.Size = new System.Drawing.Size(100, 22);
            this.txtOraInceput.TabIndex = 10;
            // 
            // txtOraSfarsit
            // 
            this.txtOraSfarsit.Location = new System.Drawing.Point(41, 360);
            this.txtOraSfarsit.Name = "txtOraSfarsit";
            this.txtOraSfarsit.Size = new System.Drawing.Size(100, 22);
            this.txtOraSfarsit.TabIndex = 11;
            // 
            // lblOraInceput
            // 
            this.lblOraInceput.AutoSize = true;
            this.lblOraInceput.Location = new System.Drawing.Point(41, 272);
            this.lblOraInceput.Name = "lblOraInceput";
            this.lblOraInceput.Size = new System.Drawing.Size(75, 16);
            this.lblOraInceput.TabIndex = 12;
            this.lblOraInceput.Text = "Ora inceput";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ora sfarsit";
            // 
            // FormOraProgramata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOraInceput);
            this.Controls.Add(this.txtOraSfarsit);
            this.Controls.Add(this.txtOraInceput);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.lblZi);
            this.Controls.Add(this.cmbZi);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblMaterie);
            this.Controls.Add(this.lblcmbProfesor);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.cmbMaterie);
            this.Controls.Add(this.cmbProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOraProgramata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOraProgramata";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.ComboBox cmbMaterie;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label lblcmbProfesor;
        private System.Windows.Forms.Label lblMaterie;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.ComboBox cmbZi;
        private System.Windows.Forms.Label lblZi;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOraInceput;
        private System.Windows.Forms.TextBox txtOraSfarsit;
        private System.Windows.Forms.TextBox txtOraInceput;
    }
}