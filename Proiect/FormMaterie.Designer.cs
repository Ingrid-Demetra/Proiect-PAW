namespace Proiect
{
    partial class FormMaterie
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
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.blDenumire = new System.Windows.Forms.Label();
            this.lblAnStudiu = new System.Windows.Forms.Label();
            this.nudAnStudiu = new System.Windows.Forms.NumericUpDown();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProviderMaterie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnStudiu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaterie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(46, 68);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 22);
            this.txtDenumire.TabIndex = 0;
            // 
            // blDenumire
            // 
            this.blDenumire.AutoSize = true;
            this.blDenumire.Location = new System.Drawing.Point(46, 46);
            this.blDenumire.Name = "blDenumire";
            this.blDenumire.Size = new System.Drawing.Size(65, 16);
            this.blDenumire.TabIndex = 1;
            this.blDenumire.Text = "Denumire";
            // 
            // lblAnStudiu
            // 
            this.lblAnStudiu.AutoSize = true;
            this.lblAnStudiu.Location = new System.Drawing.Point(46, 122);
            this.lblAnStudiu.Name = "lblAnStudiu";
            this.lblAnStudiu.Size = new System.Drawing.Size(61, 16);
            this.lblAnStudiu.TabIndex = 2;
            this.lblAnStudiu.Text = "An studiu";
            // 
            // nudAnStudiu
            // 
            this.nudAnStudiu.Location = new System.Drawing.Point(49, 155);
            this.nudAnStudiu.Name = "nudAnStudiu";
            this.nudAnStudiu.Size = new System.Drawing.Size(120, 22);
            this.nudAnStudiu.TabIndex = 3;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(542, 395);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(120, 35);
            this.btnSalveaza.TabIndex = 4;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(668, 395);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(120, 35);
            this.btnAnuleaza.TabIndex = 5;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // errorProviderMaterie
            // 
            this.errorProviderMaterie.ContainerControl = this;
            // 
            // FormMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.nudAnStudiu);
            this.Controls.Add(this.lblAnStudiu);
            this.Controls.Add(this.blDenumire);
            this.Controls.Add(this.txtDenumire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMaterie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaterieRepository";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnStudiu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaterie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label blDenumire;
        private System.Windows.Forms.Label lblAnStudiu;
        private System.Windows.Forms.NumericUpDown nudAnStudiu;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProviderMaterie;
    }
}