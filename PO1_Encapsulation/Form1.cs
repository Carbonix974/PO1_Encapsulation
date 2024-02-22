namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage();
        Personnage dragon = new Personnage();


        public Form1()
        {
            InitializeComponent();
            joueur.PointDevie = 10;
            joueur.PointDePuissance = 1;

            dragon.PointDevie = joueur.PointDevie * 3;
            dragon.PointDePuissance = joueur.PointDePuissance * 3;

        }

        private void ActualiserLabels()
        {
            lbl_pointsVieJoueur.Text = "Vie du joueur :" + joueur.PointDevie.ToString();
            lbl_pointsVieDragon.Text = "Vie du dragon :" + dragon.PointDevie.ToString();
            lbl_puissanceAttaqueJoueur.Text = "Puissance du joueur :" + joueur.PointDePuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = "Puissance du dragon :" + dragon.PointDePuissance.ToString();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointDevie -= joueur.PointDePuissance;
            ActualiserLabels();
            TourDragon();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointDevie += 5;
            ActualiserLabels();
            TourDragon();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PointDePuissance++;
            ActualiserLabels();
            TourDragon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void TourDragon()
        {
            joueur.PointDevie -= dragon.PointDePuissance;
        }
        
    }
}