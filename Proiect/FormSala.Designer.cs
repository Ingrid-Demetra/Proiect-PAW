namespace Proiect
{
    partial class FormSala
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
            this.nudNumarSala = new System.Windows.Forms.NumericUpDown();
            this.nudCapacitate = new System.Windows.Forms.NumericUpDown();
            this.lblNrSala = new System.Windows.Forms.Label();
            this.lblCapacitate = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProviderSali = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumarSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSali)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumarSala
            // 
            this.nudNumarSala.Location = new System.Drawing.Point(46, 56);
            this.nudNumarSala.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudNumarSala.Name = "nudNumarSala";
            this.nudNumarSala.Size = new System.Drawing.Size(120, 22);
            this.nudNumarSala.TabIndex = 0;
            // 
            // nudCapacitate
            // 
            this.nudCapacitate.Location = new System.Drawing.Point(46, 122);
            this.nudCapacitate.Name = "nudCapacitate";
            this.nudCapacitate.Size = new System.Drawing.Size(120, 22);
            this.nudCapacitate.TabIndex = 1;
            // 
            // lblNrSala
            // 
            this.lblNrSala.AutoSize = true;
            this.lblNrSala.Location = new System.Drawing.Point(46, 34);
            this.lblNrSala.Name = "lblNrSala";
            this.lblNrSala.Size = new System.Drawing.Size(78, 16);
            this.lblNrSala.TabIndex = 2;
            this.lblNrSala.Text = "Numar Sala";
            // 
            // lblCapacitate
            // 
            this.lblCapacitate.AutoSize = true;
            this.lblCapacitate.Location = new System.Drawing.Point(46, 103);
            this.lblCapacitate.Name = "lblCapacitate";
            this.lblCapacitate.Size = new System.Drawing.Size(72, 16);
            this.lblCapacitate.TabIndex = 3;
            this.lblCapacitate.Text = "Capacitate";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(529, 399);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(120, 35);
            this.btnSalveaza.TabIndex = 7;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(668, 399);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(120, 35);
            this.btnAnuleaza.TabIndex = 8;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // errorProviderSali
            // 
            this.errorProviderSali.ContainerControl = this;
            // 
            // FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.lblCapacitate);
            this.Controls.Add(this.lblNrSala);
            this.Controls.Add(this.nudCapacitate);
            this.Controls.Add(this.nudNumarSala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sala";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumarSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumarSala;
        private System.Windows.Forms.NumericUpDown nudCapacitate;
        private System.Windows.Forms.Label lblNrSala;
        private System.Windows.Forms.Label lblCapacitate;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProviderSali;
    }
}