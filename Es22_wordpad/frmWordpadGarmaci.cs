using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Es22_wordpad
{
    public partial class frmWordpadGarmaci : Form
    {
        public frmWordpadGarmaci()
        {
            InitializeComponent();
        }

        private void apriToolStripButton_Click(object sender, EventArgs e)
        {
            apri();
        }

        private void apri()
        {
            
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "File rtf (*.rtf;*.txt)|" + "*.rtf;*.txt|Tutti i file (*.*)|*.*";
            of.FileName = "*.rtf";
            DialogResult ris = of.ShowDialog();
            MessageBox.Show("Il file si sta aprendo...");
            if (ris == DialogResult.OK)
                rtb.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
            
        }

        private void salva()
        {
            rtb.SaveFile(Application.StartupPath + "\\pippo.rtf");
            MessageBox.Show("Il file è stato salvato correttamente!");
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apri();
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salva();
        }

        private void puntatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionBullet = true;
        }

        private void numeratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            rtb.Font = fd.Font;
        }

        private void sfondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            rtb.SelectionBackColor = cd.Color;
        }

        private void testoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            rtb.SelectionColor = cd.Color;
        }

        private void sinistraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void destraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void giustificatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tagliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taglia();
        }

        private void copiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copia();
        }

        private void incollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incolla();
        }
        
        private void taglia()
        {
            rtb.Cut();
        }

        private void copia()
        {
            rtb.Copy();
        }

        private void incolla()
        {
            rtb.Paste();
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuovo();
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            nuovo();
        }

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvaConNome();
        }

        private void salvaConNome()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "File rtf (*.rtf;*.txt)|" +"*.rtf;*.txt|Tutti i file (*.*)|*.*";
            sf.FileName = "*.rtf";
            DialogResult ris = sf.ShowDialog();
            if (ris == DialogResult.OK)
                rtb.SaveFile(sf.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sf.FileName;
        }

        private void nuovo()
        {
            rtb.Clear();
        }

        private void annullaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void ripristinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.ResetText();
        }

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stampa();
        }

        private void stampaToolStripButton_Click(object sender, EventArgs e)
        {
            stampa();
        }

        private void stampa()
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void selezionatuttoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }
    }
}
