using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ChangeMetadataFile
{
    public partial class Form1 : Form
    {
        DateTime dtCreateFile = new DateTime();
        DateTime dtChangeFile = new DateTime();
        string fullPathFile = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt_criacao.Text = DateTime.Now.ToString();            
            dt_alteracao.Text = DateTime.Now.ToString();
            fullPathFile = string.Empty;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e){}
        private void opt_file_FileOk(object sender, CancelEventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            dtChangeFile = dt_alteracao.Value;
        }
        private void dt_criacao_ValueChanged(object sender, EventArgs e)
        {
            dtCreateFile = dt_criacao.Value;
        }
        private void btn_file_Click(object sender, EventArgs e)
        {
            this.opt_file = new System.Windows.Forms.OpenFileDialog();
            var windowsReturn = opt_file.ShowDialog();
            if (windowsReturn == DialogResult.OK)
            {
                fullPathFile = opt_file.FileName;
                btn_file.Text = opt_file.SafeFileName;
            }
        }
        private void btn_processar_Click(object sender, EventArgs e)
        {
                ChangeDates();
        }
        private void ChangeDates()
        {
            if (String.IsNullOrEmpty(fullPathFile))
            {
                MessageBox.Show("Arquivo não anexado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else {
                File.SetCreationTime(fullPathFile, dtCreateFile);
                File.SetLastWriteTime(fullPathFile, dtChangeFile);
                File.SetLastAccessTime(fullPathFile, dtChangeFile);
            }
        }
    }
}
