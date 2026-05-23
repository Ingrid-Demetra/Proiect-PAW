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
            this.tabMaterii = new System.Windows.Forms.TabPage();
            this.tabSali = new System.Windows.Forms.TabPage();
            this.tabOrar = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
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
            this.tabProfesori.Location = new System.Drawing.Point(4, 25);
            this.tabProfesori.Name = "tabProfesori";
            this.tabProfesori.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesori.Size = new System.Drawing.Size(884, 477);
            this.tabProfesori.TabIndex = 0;
            this.tabProfesori.Text = "Profesori";
            this.tabProfesori.UseVisualStyleBackColor = true;
            // 
            // tabMaterii
            // 
            this.tabMaterii.Location = new System.Drawing.Point(4, 25);
            this.tabMaterii.Name = "tabMaterii";
            this.tabMaterii.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterii.Size = new System.Drawing.Size(751, 396);
            this.tabMaterii.TabIndex = 1;
            this.tabMaterii.Text = "Materii";
            this.tabMaterii.UseVisualStyleBackColor = true;
            // 
            // tabSali
            // 
            this.tabSali.Location = new System.Drawing.Point(4, 25);
            this.tabSali.Name = "tabSali";
            this.tabSali.Padding = new System.Windows.Forms.Padding(3);
            this.tabSali.Size = new System.Drawing.Size(751, 396);
            this.tabSali.TabIndex = 2;
            this.tabSali.Text = "Sali";
            this.tabSali.UseVisualStyleBackColor = true;
            // 
            // tabOrar
            // 
            this.tabOrar.Location = new System.Drawing.Point(4, 25);
            this.tabOrar.Name = "tabOrar";
            this.tabOrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrar.Size = new System.Drawing.Size(751, 396);
            this.tabOrar.TabIndex = 3;
            this.tabOrar.Text = "Orar";
            this.tabOrar.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProfesori;
        private System.Windows.Forms.TabPage tabMaterii;
        private System.Windows.Forms.TabPage tabSali;
        private System.Windows.Forms.TabPage tabOrar;
    }
}

