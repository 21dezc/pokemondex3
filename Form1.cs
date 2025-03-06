using System.Data;

namespace pokemondex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowPokemon("Pikachu"); // ให้ Pikachu เป็นตัวแรกเมื่อเปิดโปรแกรม
        }

        private void ShowPokemon(string name)
        {
            Pokemon pokemon = PokemonFactory.GetPokemon(name);

            if (pokemon != null)
            {
                lbName.Text = pokemon.Name;
                lbType.Text = pokemon.Type;
                lbStats.Text = $"Height : {pokemon.Height}\nWeight : {pokemon.Weight}\n" +
                    $"HP : {pokemon.HP}\nAttack : {pokemon.Attack}\n" +
                    $"Defense : {pokemon.Defense}\nSpecial Attack : {pokemon.SpecialAttack}\n" +
                    $"Special Defense : {pokemon.SpecialDefense}\nSpeed : {pokemon.Speed}\n" +
                    $"Total : {pokemon.Total}";

                // โหลดรูปจากโฟลเดอร์ Images/
                string imagePath = $"Images/{pokemon.Name}.jpg";
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show($"ไม่พบรูปภาพที่ {imagePath}");  // Debug message
                }
            }

        }


        private void btnMew_Click(object sender, EventArgs e)
        {
            ShowPokemon("Mew");
        }

        private void btnPikachu_Click(object sender, EventArgs e)
        {
            ShowPokemon("Pikachu");
        }

        private void btnSwirlix_Click(object sender, EventArgs e)
        {
            ShowPokemon("Swirlix");
        }

        private void btnSylveon_Click(object sender, EventArgs e)
        {
            ShowPokemon("Sylveon");
        }

        private void btnWhismur_Click(object sender, EventArgs e)
        {
            ShowPokemon("Whismur");
        }

        private void btnAlcremie_Click(object sender, EventArgs e)
        {
            ShowPokemon("Alcremie");
        }
    }
}

