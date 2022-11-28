namespace AccesAuxFichiers
{
    partial class frmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.panelGauche = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelDroite = new System.Windows.Forms.Panel();
            this.lblFermer = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnFormatter = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFS = new System.Windows.Forms.TextBox();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFS = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.labelDisque = new System.Windows.Forms.Label();
            this.cboDisque = new System.Windows.Forms.ComboBox();
            this.labelNew = new System.Windows.Forms.Label();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelDroite.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGauche
            // 
            this.panelGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelGauche.Controls.Add(this.pictureBox);
            this.panelGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGauche.Location = new System.Drawing.Point(0, 0);
            this.panelGauche.Name = "panelGauche";
            this.panelGauche.Size = new System.Drawing.Size(161, 437);
            this.panelGauche.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(137, 121);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panelDroite
            // 
            this.panelDroite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDroite.Controls.Add(this.lblFermer);
            this.panelDroite.Controls.Add(this.lblErreur);
            this.panelDroite.Controls.Add(this.btnFormatter);
            this.panelDroite.Controls.Add(this.txtNom);
            this.panelDroite.Controls.Add(this.txtType);
            this.panelDroite.Controls.Add(this.txtFS);
            this.panelDroite.Controls.Add(this.txtTaille);
            this.panelDroite.Controls.Add(this.lblNom);
            this.panelDroite.Controls.Add(this.lblType);
            this.panelDroite.Controls.Add(this.lblFS);
            this.panelDroite.Controls.Add(this.lblTaille);
            this.panelDroite.Controls.Add(this.labelDisque);
            this.panelDroite.Controls.Add(this.cboDisque);
            this.panelDroite.Controls.Add(this.labelNew);
            this.panelDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDroite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelDroite.Location = new System.Drawing.Point(161, 0);
            this.panelDroite.Name = "panelDroite";
            this.panelDroite.Size = new System.Drawing.Size(322, 437);
            this.panelDroite.TabIndex = 1;
            // 
            // lblFermer
            // 
            this.lblFermer.AutoSize = true;
            this.lblFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFermer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFermer.Location = new System.Drawing.Point(290, 9);
            this.lblFermer.Name = "lblFermer";
            this.lblFermer.Size = new System.Drawing.Size(20, 19);
            this.lblFermer.TabIndex = 6;
            this.lblFermer.Text = "X";
            this.lblFermer.Click += new System.EventHandler(this.lblFermer_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblErreur.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Blue;
            this.lblErreur.Location = new System.Drawing.Point(29, 347);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(262, 62);
            this.lblErreur.TabIndex = 5;
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormatter
            // 
            this.btnFormatter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormatter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatter.Location = new System.Drawing.Point(118, 296);
            this.btnFormatter.Name = "btnFormatter";
            this.btnFormatter.Size = new System.Drawing.Size(93, 39);
            this.btnFormatter.TabIndex = 4;
            this.btnFormatter.Text = "&Formatter";
            this.btnFormatter.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(118, 253);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(93, 23);
            this.txtNom.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtType.Location = new System.Drawing.Point(118, 206);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(136, 23);
            this.txtType.TabIndex = 2;
            // 
            // txtFS
            // 
            this.txtFS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFS.Location = new System.Drawing.Point(118, 165);
            this.txtFS.Name = "txtFS";
            this.txtFS.ReadOnly = true;
            this.txtFS.Size = new System.Drawing.Size(60, 23);
            this.txtFS.TabIndex = 2;
            // 
            // txtTaille
            // 
            this.txtTaille.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTaille.Location = new System.Drawing.Point(118, 125);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.ReadOnly = true;
            this.txtTaille.Size = new System.Drawing.Size(79, 23);
            this.txtTaille.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(48, 256);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(48, 17);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(52, 209);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type :";
            // 
            // lblFS
            // 
            this.lblFS.AutoSize = true;
            this.lblFS.Location = new System.Drawing.Point(68, 168);
            this.lblFS.Name = "lblFS";
            this.lblFS.Size = new System.Drawing.Size(28, 17);
            this.lblFS.TabIndex = 2;
            this.lblFS.Text = "FS :";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(49, 128);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(47, 17);
            this.lblTaille.TabIndex = 2;
            this.lblTaille.Text = "Taille :";
            // 
            // labelDisque
            // 
            this.labelDisque.AutoSize = true;
            this.labelDisque.Location = new System.Drawing.Point(37, 88);
            this.labelDisque.Name = "labelDisque";
            this.labelDisque.Size = new System.Drawing.Size(59, 17);
            this.labelDisque.TabIndex = 2;
            this.labelDisque.Text = "Disque :";
            // 
            // cboDisque
            // 
            this.cboDisque.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboDisque.DisplayMember = "Disk";
            this.cboDisque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.cboDisque.FormattingEnabled = true;
            this.cboDisque.Location = new System.Drawing.Point(118, 83);
            this.cboDisque.Name = "cboDisque";
            this.cboDisque.Size = new System.Drawing.Size(136, 25);
            this.cboDisque.TabIndex = 0;
            this.cboDisque.ValueMember = "Disk";
            this.cboDisque.SelectionChangeCommitted += new System.EventHandler(this.cboDisque_SelectionChangeCommitted);
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNew.Location = new System.Drawing.Point(67, 38);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(162, 21);
            this.labelNew.TabIndex = 0;
            this.labelNew.Text = "New formating way";
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 30;
            this.bunifuElipse.TargetControl = this;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelDroite;
            this.bunifuDragControl.Vertical = true;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 437);
            this.Controls.Add(this.panelDroite);
            this.Controls.Add(this.panelGauche);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAccueil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCES AUX FICHIERS";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.panelGauche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelDroite.ResumeLayout(false);
            this.panelDroite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGauche;
        private System.Windows.Forms.Panel panelDroite;
        private System.Windows.Forms.Button btnFormatter;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFS;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblFS;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label labelDisque;
        private System.Windows.Forms.ComboBox cboDisque;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblErreur;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Label lblFermer;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
    }
}

