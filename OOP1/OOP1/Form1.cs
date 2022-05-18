namespace OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Human human1 = new Human();
            human1.AdSoyad = "Eray Gürbüz";
            human1.CanliMi = false;
            /////////////
            Human human2 = new Human();
            human2.CanliMi = true;
            human2.AdSoyad = "Erdi Gürbüz";
            //////////////
            Human human3 = new Human();
            human3.CanliMi = true;
            human3.AdSoyad = "Firdevs Bacý";
            ///////////////
            Human human4 = new Human("Atýl Say");
            human4.CanliMi = false;
            //////////////
            Human human5 = new Human("chavez ");
            //////////////
            MessageBox.Show(human1.AdiniSoyle());
            MessageBox.Show(Human.SelamVer());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCVatandas tcVatandas = new TCVatandas
            {
                DogumTarihi = Convert.ToDateTime("2003-06-10"),
                
            };
            MessageBox.Show(tcVatandas.VizeAl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABDVatandas abd1 = new ABDVatandas();
            abd1.AdSoyad = "Michael Ricotta";
            abd1.Dil = "English";
            abd1.Dogumtarihi = Convert.ToDateTime("1985-01-01");
            MessageBox.Show(abd1.Yas.ToString());
        }
    }
}