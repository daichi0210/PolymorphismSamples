namespace PolymorphismSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Animal animalCookie;

        private void buttonSing_Click(object sender, EventArgs e)
        {
            animalCookie = new Dog();
            pictureBoxDog.Image = animalCookie.Sing();
            animalCookie = new Cat();
            pictureBoxCat.Image = animalCookie.Sing();
            animalCookie = new Bird();
            pictureBoxBird.Image = animalCookie.Sing();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            animalCookie = new Dog();
            pictureBoxDog.Image = animalCookie.Reset();
            animalCookie = new Cat();
            pictureBoxCat.Image = animalCookie.Reset();
            animalCookie = new Bird();
            pictureBoxBird.Image = animalCookie.Reset();
        }
    }
}
