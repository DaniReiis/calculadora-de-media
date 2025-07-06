namespace calculadora_de_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //limpar
        {
            this.Controls["label7"].Text = " ";

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Clear();
                }
                this.Controls["label7"].Text = "...";

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //calcular
        {
            float soma, media, valor;
            soma = 0;

            foreach ( Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                valor = Convert.ToSingle(((TextBox) controle).Text);
                soma += valor;

                }

                media = soma / 4;
                this.Controls["label7"].Text = media.ToString(); // Formata a média com 2 casas decimais
            }
        }
    }
}
