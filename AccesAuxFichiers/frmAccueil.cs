using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AccesAuxFichiers
{
    public partial class frmAccueil : Form
    {
        DriveInfo di;        
        List<DriveInfo> list = new List<DriveInfo> ();
        public string[] logical = Directory.GetLogicalDrives();

        public frmAccueil()
        {
            InitializeComponent();
        }

        private void cboDisque_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Selectionner();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            Charger();
            Selectionner();
        }

        private void Selectionner()
        {
            DriveInfo obj = cboDisque.SelectedItem as DriveInfo;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (obj != null)
                {
                    di = new DriveInfo(string.Format("{0}:", obj));
                    txtFS.Text = string.Format("{0}", di.DriveFormat);
                    txtTaille.Text = string.Format("{0:###,##.##} GB", (double)di.TotalSize/(1024*1024*1024));
                    txtNom.Text = di.VolumeLabel;
                    //
                    DriveType type = di.DriveType;
                    switch (type)
                    {
                        case  DriveType.Removable:
                            txtType.Text = "Mémoire amovible";
                            break;
                        case DriveType.Fixed:
                            txtType.Text = "Mémoire fixe";
                            break;
                        case DriveType.Unknown:
                            txtType.Text = "Inconnue";
                            break;
                        case DriveType.CDRom:
                            txtType.Text = "CD-R";
                            break;
                        case DriveType.Network:
                            txtType.Text = "Réseau";
                            break;
                        default:
                            txtType.Text = " ";
                            break;
                    }
                }
                lblErreur.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblErreur.Text = ex.Message;
                cboDisque.Text = cboDisque.SelectedText;
                txtFS.Text = string.Empty;
                txtTaille.Text = string.Empty;
                txtType.Text = string.Empty;
                txtNom.Text = string.Empty;
            }
            Cursor.Current = Cursors.Default;
        }

        private void Charger()
        {
            foreach (string drive in logical)
                list.Add(new DriveInfo(drive));
            try
            {
                cboDisque.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErreur.Text = string.Empty;
            }
        }

        private void lblFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
