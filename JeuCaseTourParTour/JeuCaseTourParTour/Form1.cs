namespace JeuCaseTourParTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Personnage p1 = new Personnage(0, 0, 2);
            List<Personnage> lp = new List<Personnage>();
            lp.Add(p1);
            Carte carte = new Carte(-10, 10, -10, 10);
            Combat c = new Combat(carte, lp, lp);
            label1.Text = p1.getPos();
            c.SeDeplacer(p1, 0, -2);
            label2.Text = p1.getPos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}