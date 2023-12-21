using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JogoForca
{
    public class Forca
    {
        private List<string> palavras;
        private List<string> temas;
        private string palavraSecreta;
        private List<char> letrasTentadas;
        private int errosMaximos;
        private int errosAtuais;

        public Forca()
        {
            palavras = new List<string>();
            temas = new List<string>();
            letrasTentadas = new List<char>();

            AdicionarPalavraETema("ABACAXI", "Frutas");
            AdicionarPalavraETema("ELEFANTE", "Animais");
            AdicionarPalavraETema("GIRASSOL", "Plantas");
            AdicionarPalavraETema("CARRO", "Veículos");
            AdicionarPalavraETema("PRAIA", "Lugares");
            AdicionarPalavraETema("FUTEBOL", "Esportes");
            AdicionarPalavraETema("PIZZA", "Comidas");
            AdicionarPalavraETema("CELULAR", "Tecnologia");
            AdicionarPalavraETema("GUITARRA", "Instrumentos Musicais");
            AdicionarPalavraETema("LIVRO", "Literatura");
            AdicionarPalavraETema("AVIÃO", "Transportes");
            AdicionarPalavraETema("CACHORRO", "Animais");
            AdicionarPalavraETema("CASA", "Lugares");
            AdicionarPalavraETema("COMPUTADOR", "Tecnologia");
            AdicionarPalavraETema("MÚSICA", "Arte");
            AdicionarPalavraETema("CANETA", "Material Escolar");
            AdicionarPalavraETema("DANÇA", "Arte");
            AdicionarPalavraETema("JARDIM", "Lugares");
            AdicionarPalavraETema("VIAGEM", "Atividades");
            AdicionarPalavraETema("MICROFONE", "Instrumentos Musicais");

            errosMaximos = 6;
            errosAtuais = 0;
        }

        private void AdicionarPalavraETema(string palavra, string tema)
        {
            palavras.Add(palavra.ToUpper());
            temas.Add(tema);
        }

        public string ObterTemaDaPalavraEmJogo()
        {
            int indicePalavra = palavras.IndexOf(palavraSecreta);
            if (indicePalavra >= 0 && indicePalavra < temas.Count)
            {
                return temas[indicePalavra];
            }

            return "Tema não encontrado";
        }   

        public void IniciarNovoJogo()
        {
            Random random = new Random();
            int index = random.Next(palavras.Count);
            palavraSecreta = palavras[index].ToUpper();
            letrasTentadas.Clear();
            errosAtuais = 0;
        }

        public string ObterPalavraEmJogo()
        {
            string palavraExibida = "";

            foreach (char letra in palavraSecreta)
            {
                if (letrasTentadas.Contains(letra))
                {
                    palavraExibida += letra + " ";
                }
                else
                {
                    palavraExibida += "_ ";
                }
            }

            return palavraExibida;
        }

        public int ObterErrosAtuais()
        {
            return errosAtuais;
        }

        public int ObterErrosMaximos()
        {
            return errosMaximos;
        }

        public bool TentarLetra(char letra)
        {
            letrasTentadas.Add(letra);

            if (!palavraSecreta.Contains(letra))
            {
                errosAtuais++;
                return false;
            }

            return true;
        }

        public bool JogoAcabou()
        {
            return errosAtuais >= errosMaximos || PalavraDescoberta();
        }

        public bool PalavraDescoberta()
        {
            foreach (char letra in palavraSecreta)
            {
                if (!letrasTentadas.Contains(letra))
                {
                    return false;
                }
            }
            return true;
        }

        public string ObterPalavraSecreta()
        {
            return palavraSecreta;
        }

        public List<char> ObterLetrasTentadas()
        {
            return letrasTentadas;
        }
    }
}
