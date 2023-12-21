using System;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class Form1 : Form
    {
        private Forca jogoForca;

        public Form1()
        {
            InitializeComponent();
            jogoForca = new Forca();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void NovoJogo()
        {
            jogoForca.IniciarNovoJogo();
            AtualizarInterface();
        }

        private void AtualizarInterface()
        {
            lblPalavra.Text = jogoForca.ObterPalavraEmJogo();
            lblLetrasTentadas.Text = "Letras Tentadas: " + string.Join(", ", jogoForca.ObterLetrasTentadas());
            lblTema.Text = "Tema: " + jogoForca.ObterTemaDaPalavraEmJogo();
            lblErros.Text = "Erros: " + jogoForca.ObterErrosAtuais() + " / " + jogoForca.ObterErrosMaximos();

            if (jogoForca.JogoAcabou())
            {
                if (jogoForca.PalavraDescoberta())
                {
                    MessageBox.Show("Parabéns! Você descobriu a palavra: " + jogoForca.ObterPalavraSecreta());
                }
                else
                {
                    MessageBox.Show("Você excedeu o número máximo de erros. A palavra era: " + jogoForca.ObterPalavraSecreta());
                }
                NovoJogo();
            }
        }


        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovoJogo_Click_1(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void btnTentar_Click_1(object sender, EventArgs e)
        {
            char letra;

            if (txtLetra.TextLength > 0)
            {
                letra = txtLetra.Text.ToUpper()[0];

                if (!Char.IsLetter(letra))
                {
                    MessageBox.Show("Por favor, insira uma letra válida!");
                    return;
                }

                if (jogoForca.ObterLetrasTentadas().Contains(letra))
                {
                    MessageBox.Show("Você já tentou esta letra!");
                    return;
                }

                jogoForca.TentarLetra(letra);
                AtualizarInterface();
                txtLetra.Text = "";
            }
        }

    }
}
