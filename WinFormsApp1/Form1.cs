namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*this.Text = "Fenetre 1";
            this.BackColor = Color.Red;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenue à mon application bureau");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Au revoir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string prenom = textBox2.Text;
            if (nom != "" && prenom != "")
            {
                string email = nom + "." + prenom + "@esisa.com";
                textBox3.Text = email;
            }
            else
                MessageBox.Show("Veuillez saisir le nom et le prénom svp!", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant { Nom=textBox1.Text,
            Prenom=textBox2.Text,
            Email=textBox3.Text};
            Form2 f = new Form2();
            f.Etudiant = etudiant;
            f.ShowDialog();
        }
    }
}