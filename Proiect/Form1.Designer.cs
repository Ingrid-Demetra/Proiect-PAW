namespace Proiect
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProfesori = new System.Windows.Forms.TabPage();
            this.panelProfesori = new System.Windows.Forms.Panel();
            this.btnStergeProfesor = new System.Windows.Forms.Button();
            this.btnEditeazaProfesor = new System.Windows.Forms.Button();
            this.btnAdaugaProfesor = new System.Windows.Forms.Button();
            this.dgvProfesori = new System.Windows.Forms.DataGridView();
            this.tabMaterii = new System.Windows.Forms.TabPage();
            this.panelMaterii = new System.Windows.Forms.Panel();
            this.btnStergeMaterie = new System.Windows.Forms.Button();
            this.btnEditeazaMaterie = new System.Windows.Forms.Button();
            this.btnAdaugaMaterie = new System.Windows.Forms.Button();
            this.dgvMaterii = new System.Windows.Forms.DataGridView();
            this.tabSali = new System.Windows.Forms.TabPage();
            this.panelSali = new System.Windows.Forms.Panel();
            this.btnStergeSala = new System.Windows.Forms.Button();
            this.btnEditeazaSala = new System.Windows.Forms.Button();
            this.btnAdaugaSala = new System.Windows.Forms.Button();
            this.dgvSali = new System.Windows.Forms.DataGridView();
            this.tabOrar = new System.Windows.Forms.TabPage();
            this.PanelOrar = new System.Windows.Forms.Panel();
            this.btnStergeOrar = new System.Windows.Forms.Button();
            this.btnEditeazaOrar = new System.Windows.Forms.Button();
            this.btnAdaugaOrar = new System.Windows.Forms.Button();
            this.dgvOrar = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabProfesori.SuspendLayout();
            this.panelProfesori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).BeginInit();
            this.tabMaterii.SuspendLayout();
            this.panelMaterii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterii)).BeginInit();
            this.tabSali.SuspendLayout();
            this.panelSali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSali)).BeginInit();
            this.tabOrar.SuspendLayout();
            this.PanelOrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProfesori);
            this.tabControl.Controls.Add(this.tabMaterii);
            this.tabControl.Controls.Add(this.tabSali);
            this.tabControl.Controls.Add(this.tabOrar);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(892, 506);
            this.tabControl.TabIndex = 0;
            // 
            // tabProfesori
            // 
            this.tabProfesori.Controls.Add(this.panelProfesori);
            this.tabProfesori.Controls.Add(this.dgvProfesori);
            this.tabProfesori.Location = new System.Drawing.Point(4, 25);
            this.tabProfesori.Name = "tabProfesori";
            this.tabProfesori.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesori.Size = new System.Drawing.Size(884, 477);
            this.tabProfesori.TabIndex = 0;
            this.tabProfesori.Text = "Profesori";
            this.tabProfesori.UseVisualStyleBackColor = true;
            // 
            // panelProfesori
            // 
            this.panelProfesori.Controls.Add(this.btnStergeProfesor);
            this.panelProfesori.Controls.Add(this.btnEditeazaProfesor);
            this.panelProfesori.Controls.Add(this.btnAdaugaProfesor);
            this.panelProfesori.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProfesori.Location = new System.Drawing.Point(3, 434);
            this.panelProfesori.Name = "panelProfesori";
            this.panelProfesori.Size = new System.Drawing.Size(878, 40);
            this.panelProfesori.TabIndex = 1;
            // 
            // btnStergeProfesor
            // 
            this.btnStergeProfesor.Location = new System.Drawing.Point(196, 12);
            this.btnStergeProfesor.Name = "btnStergeProfesor";
            this.btnStergeProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnStergeProfesor.TabIndex = 2;
            this.btnStergeProfesor.Text = "Sterge";
            this.btnStergeProfesor.UseVisualStyleBackColor = true;
            this.btnStergeProfesor.Click += new System.EventHandler(this.btnStergeProfesor_Click);
            // 
            // btnEditeazaProfesor
            // 
            this.btnEditeazaProfesor.Location = new System.Drawing.Point(104, 12);
            this.btnEditeazaProfesor.Name = "btnEditeazaProfesor";
            this.btnEditeazaProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnEditeazaProfesor.TabIndex = 1;
            this.btnEditeazaProfesor.Text = "Editeaza";
            this.btnEditeazaProfesor.UseVisualStyleBackColor = true;
            this.btnEditeazaProfesor.Click += new System.EventHandler(this.btnEditeazaProfesor_Click);
            // 
            // btnAdaugaProfesor
            // 
            this.btnAdaugaProfesor.Location = new System.Drawing.Point(10, 12);
            this.btnAdaugaProfesor.Name = "btnAdaugaProfesor";
            this.btnAdaugaProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaProfesor.TabIndex = 0;
            this.btnAdaugaProfesor.Text = "Adauga";
            this.btnAdaugaProfesor.UseVisualStyleBackColor = true;
            this.btnAdaugaProfesor.Click += new System.EventHandler(this.btnAdaugaProfesor_Click);
            // 
            // dgvProfesori
            // 
            this.dgvProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfesori.Location = new System.Drawing.Point(3, 3);
            this.dgvProfesori.Name = "dgvProfesori";
            this.dgvProfesori.RowHeadersWidth = 51;
            this.dgvProfesori.RowTemplate.Height = 24;
            this.dgvProfesori.Size = new System.Drawing.Size(878, 471);
            this.dgvProfesori.TabIndex = 0;
            // 
            // tabMaterii
            // 
            this.tabMaterii.Controls.Add(this.panelMaterii);
            this.tabMaterii.Controls.Add(this.dgvMaterii);
            this.tabMaterii.Location = new System.Drawing.Point(4, 25);
            this.tabMaterii.Name = "tabMaterii";
            this.tabMaterii.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterii.Size = new System.Drawing.Size(884, 477);
            this.tabMaterii.TabIndex = 1;
            this.tabMaterii.Text = "Materii";
            this.tabMaterii.UseVisualStyleBackColor = true;
            // 
            // panelMaterii
            // 
            this.panelMaterii.Controls.Add(this.btnStergeMaterie);
            this.panelMaterii.Controls.Add(this.btnEditeazaMaterie);
            this.panelMaterii.Controls.Add(this.btnAdaugaMaterie);
            this.panelMaterii.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMaterii.Location = new System.Drawing.Point(3, 434);
            this.panelMaterii.Name = "panelMaterii";
            this.panelMaterii.Size = new System.Drawing.Size(878, 40);
            this.panelMaterii.TabIndex = 1;
            // 
            // btnStergeMaterie
            // 
            this.btnStergeMaterie.Location = new System.Drawing.Point(207, 12);
            this.btnStergeMaterie.Name = "btnStergeMaterie";
            this.btnStergeMaterie.Size = new System.Drawing.Size(75, 23);
            this.btnStergeMaterie.TabIndex = 5;
            this.btnStergeMaterie.Text = "Sterge";
            this.btnStergeMaterie.UseVisualStyleBackColor = true;
            this.btnStergeMaterie.Click += new System.EventHandler(this.btnStergeMaterie_Click);
            // 
            // btnEditeazaMaterie
            // 
            this.btnEditeazaMaterie.Location = new System.Drawing.Point(115, 12);
            this.btnEditeazaMaterie.Name = "btnEditeazaMaterie";
            this.btnEditeazaMaterie.Size = new System.Drawing.Size(75, 23);
            this.btnEditeazaMaterie.TabIndex = 4;
            this.btnEditeazaMaterie.Text = "Editeaza";
            this.btnEditeazaMaterie.UseVisualStyleBackColor = true;
            this.btnEditeazaMaterie.Click += new System.EventHandler(this.btnEditeazaMaterie_Click);
            // 
            // btnAdaugaMaterie
            // 
            this.btnAdaugaMaterie.Location = new System.Drawing.Point(21, 12);
            this.btnAdaugaMaterie.Name = "btnAdaugaMaterie";
            this.btnAdaugaMaterie.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaMaterie.TabIndex = 3;
            this.btnAdaugaMaterie.Text = "Adauga";
            this.btnAdaugaMaterie.UseVisualStyleBackColor = true;
            this.btnAdaugaMaterie.Click += new System.EventHandler(this.btnAdaugaMaterie_Click);
            // 
            // dgvMaterii
            // 
            this.dgvMaterii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterii.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterii.Name = "dgvMaterii";
            this.dgvMaterii.RowHeadersWidth = 51;
            this.dgvMaterii.RowTemplate.Height = 24;
            this.dgvMaterii.Size = new System.Drawing.Size(878, 471);
            this.dgvMaterii.TabIndex = 0;
            // 
            // tabSali
            // 
            this.tabSali.Controls.Add(this.panelSali);
            this.tabSali.Controls.Add(this.dgvSali);
            this.tabSali.Location = new System.Drawing.Point(4, 25);
            this.tabSali.Name = "tabSali";
            this.tabSali.Padding = new System.Windows.Forms.Padding(3);
            this.tabSali.Size = new System.Drawing.Size(884, 477);
            this.tabSali.TabIndex = 2;
            this.tabSali.Text = "Sali";
            this.tabSali.UseVisualStyleBackColor = true;
            // 
            // panelSali
            // 
            this.panelSali.Controls.Add(this.btnStergeSala);
            this.panelSali.Controls.Add(this.btnEditeazaSala);
            this.panelSali.Controls.Add(this.btnAdaugaSala);
            this.panelSali.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSali.Location = new System.Drawing.Point(3, 434);
            this.panelSali.Name = "panelSali";
            this.panelSali.Size = new System.Drawing.Size(878, 40);
            this.panelSali.TabIndex = 1;
            // 
            // btnStergeSala
            // 
            this.btnStergeSala.Location = new System.Drawing.Point(201, 12);
            this.btnStergeSala.Name = "btnStergeSala";
            this.btnStergeSala.Size = new System.Drawing.Size(75, 23);
            this.btnStergeSala.TabIndex = 5;
            this.btnStergeSala.Text = "Sterge";
            this.btnStergeSala.UseVisualStyleBackColor = true;
            this.btnStergeSala.Click += new System.EventHandler(this.btnStergeSala_Click);
            // 
            // btnEditeazaSala
            // 
            this.btnEditeazaSala.Location = new System.Drawing.Point(109, 12);
            this.btnEditeazaSala.Name = "btnEditeazaSala";
            this.btnEditeazaSala.Size = new System.Drawing.Size(75, 23);
            this.btnEditeazaSala.TabIndex = 4;
            this.btnEditeazaSala.Text = "Editeaza";
            this.btnEditeazaSala.UseVisualStyleBackColor = true;
            this.btnEditeazaSala.Click += new System.EventHandler(this.btnEditeazaSala_Click);
            // 
            // btnAdaugaSala
            // 
            this.btnAdaugaSala.Location = new System.Drawing.Point(15, 12);
            this.btnAdaugaSala.Name = "btnAdaugaSala";
            this.btnAdaugaSala.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaSala.TabIndex = 3;
            this.btnAdaugaSala.Text = "Adauga";
            this.btnAdaugaSala.UseVisualStyleBackColor = true;
            this.btnAdaugaSala.Click += new System.EventHandler(this.btnAdaugaSala_Click);
            // 
            // dgvSali
            // 
            this.dgvSali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSali.Location = new System.Drawing.Point(3, 3);
            this.dgvSali.Name = "dgvSali";
            this.dgvSali.RowHeadersWidth = 51;
            this.dgvSali.RowTemplate.Height = 24;
            this.dgvSali.Size = new System.Drawing.Size(878, 471);
            this.dgvSali.TabIndex = 0;
            // 
            // tabOrar
            // 
            this.tabOrar.Controls.Add(this.PanelOrar);
            this.tabOrar.Controls.Add(this.dgvOrar);
            this.tabOrar.Location = new System.Drawing.Point(4, 25);
            this.tabOrar.Name = "tabOrar";
            this.tabOrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrar.Size = new System.Drawing.Size(884, 477);
            this.tabOrar.TabIndex = 3;
            this.tabOrar.Text = "Orar";
            this.tabOrar.UseVisualStyleBackColor = true;
            // 
            // PanelOrar
            // 
            this.PanelOrar.Controls.Add(this.btnStergeOrar);
            this.PanelOrar.Controls.Add(this.btnEditeazaOrar);
            this.PanelOrar.Controls.Add(this.btnAdaugaOrar);
            this.PanelOrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelOrar.Location = new System.Drawing.Point(3, 434);
            this.PanelOrar.Name = "PanelOrar";
            this.PanelOrar.Size = new System.Drawing.Size(878, 40);
            this.PanelOrar.TabIndex = 1;
            // 
            // btnStergeOrar
            // 
            this.btnStergeOrar.Location = new System.Drawing.Point(196, 12);
            this.btnStergeOrar.Name = "btnStergeOrar";
            this.btnStergeOrar.Size = new System.Drawing.Size(75, 23);
            this.btnStergeOrar.TabIndex = 5;
            this.btnStergeOrar.Text = "Sterge";
            this.btnStergeOrar.UseVisualStyleBackColor = true;
            // 
            // btnEditeazaOrar
            // 
            this.btnEditeazaOrar.Location = new System.Drawing.Point(104, 12);
            this.btnEditeazaOrar.Name = "btnEditeazaOrar";
            this.btnEditeazaOrar.Size = new System.Drawing.Size(75, 23);
            this.btnEditeazaOrar.TabIndex = 4;
            this.btnEditeazaOrar.Text = "Editeaza";
            this.btnEditeazaOrar.UseVisualStyleBackColor = true;
            // 
            // btnAdaugaOrar
            // 
            this.btnAdaugaOrar.Location = new System.Drawing.Point(10, 12);
            this.btnAdaugaOrar.Name = "btnAdaugaOrar";
            this.btnAdaugaOrar.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaOrar.TabIndex = 3;
            this.btnAdaugaOrar.Text = "Adauga";
            this.btnAdaugaOrar.UseVisualStyleBackColor = true;
            // 
            // dgvOrar
            // 
            this.dgvOrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrar.Location = new System.Drawing.Point(3, 3);
            this.dgvOrar.Name = "dgvOrar";
            this.dgvOrar.RowHeadersWidth = 51;
            this.dgvOrar.RowTemplate.Height = 24;
            this.dgvOrar.Size = new System.Drawing.Size(878, 471);
            this.dgvOrar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 506);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabProfesori.ResumeLayout(false);
            this.panelProfesori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).EndInit();
            this.tabMaterii.ResumeLayout(false);
            this.panelMaterii.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterii)).EndInit();
            this.tabSali.ResumeLayout(false);
            this.panelSali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSali)).EndInit();
            this.tabOrar.ResumeLayout(false);
            this.PanelOrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProfesori;
        private System.Windows.Forms.TabPage tabMaterii;
        private System.Windows.Forms.TabPage tabSali;
        private System.Windows.Forms.TabPage tabOrar;
        private System.Windows.Forms.DataGridView dgvProfesori;
        private System.Windows.Forms.DataGridView dgvMaterii;
        private System.Windows.Forms.DataGridView dgvSali;
        private System.Windows.Forms.DataGridView dgvOrar;
        private System.Windows.Forms.Panel panelProfesori;
        private System.Windows.Forms.Panel panelMaterii;
        private System.Windows.Forms.Panel panelSali;
        private System.Windows.Forms.Panel PanelOrar;
        private System.Windows.Forms.Button btnStergeProfesor;
        private System.Windows.Forms.Button btnEditeazaProfesor;
        private System.Windows.Forms.Button btnAdaugaProfesor;
        private System.Windows.Forms.Button btnStergeMaterie;
        private System.Windows.Forms.Button btnEditeazaMaterie;
        private System.Windows.Forms.Button btnAdaugaMaterie;
        private System.Windows.Forms.Button btnStergeSala;
        private System.Windows.Forms.Button btnEditeazaSala;
        private System.Windows.Forms.Button btnAdaugaSala;
        private System.Windows.Forms.Button btnStergeOrar;
        private System.Windows.Forms.Button btnEditeazaOrar;
        private System.Windows.Forms.Button btnAdaugaOrar;
    }
}

