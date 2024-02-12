using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Etudiant etudiant;
        GestionEtudiants gestion = new GestionEtudiants();

        internal Etudiant Etudiant { get => etudiant; set => etudiant = value; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            etudiant.DateN = DateTime.Parse(dateTimePicker1.Text);
            etudiant.Bac = textBox2.Text;
            etudiant.Mention = (Mention)Enum.Parse(typeof(Mention), comboBox1.Text);
            if (radioButton1.Checked)
            {
                etudiant.Genre = Genre.Masculin;
            }
            else
                etudiant.Genre = Genre.Féminin;
            gestion.AddEtudiant(etudiant);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Mention.PasMention);
            comboBox1.Items.Add(Mention.Passable);
            comboBox1.Items.Add(Mention.AssezBien);
            comboBox1.Items.Add(Mention.Bien);
            comboBox1.Items.Add(Mention.TresBien);

            this.Text = etudiant.Nom + " " + etudiant.Prenom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
