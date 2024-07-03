using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Só_pra_zoar.Peerguntas
{
    public class Perguntas
    {
        public string perguntas { get; set; }
        public string Mensagem { get; set; }

        public bool PrimeiraPergunta(string resposta)
        {
            if (resposta.Replace(" ", "").ToUpper() != "4A6LITROS" && resposta.Replace("(" ,"").Replace(")","").ToUpper() != "B" && resposta != "b) Tem entre 4 a 6 litros. São retirados 450 mililitros")
            {
                Mensagem = "Errou";

                return false;
            }
            else
            {
                Mensagem = "Acertou";
                perguntas = "Próxima Pergunta!!";
                return true;
            }

        }

        public bool SegundaPergunta(string resposta)
        {


            if (resposta.Replace(" ", "").ToUpper() != "DESCARTES" && resposta.Replace("(", "").Replace(")", "").ToUpper() != "C" && resposta != "c) Descartes")
            {
                Mensagem = "Errou";

                return false;
            }
            else
            {
                Mensagem = "Acertou";
                return true;
            }
        }
        public bool TerceiraPergunta(string resposta)
        {


            if (resposta.Replace(" ", "").ToUpper() != "BRASIL" && resposta.Replace("(", "").Replace(")", "").ToUpper() != "C" && resposta == "3. De onde é a invenção do chuveiro elétrico?")
            {
                Mensagem = "Errou";

                return false;
            }
            else
            {
                Mensagem = "Acertou";
                return true;
            }
        }

        public bool QuartaPergunta(string resposta)
        {


            if (resposta.Replace(" ", "").ToUpper() != "VATICANOERUSSIA" && resposta.Replace("(", "").Replace(")", "").ToUpper() != "A" && resposta == "4.Quais o menor e o maior país do mundo ? ")
            {
                Mensagem = "Errou";

                return false;
            }
            else
            {
                Mensagem = "Acertou";
                return true;
            }
        }

        public bool QuintaPergunta(string resposta)
        {


            if (resposta.Replace(" ", "").ToUpper() != "JOAOGOULART" && resposta.Replace("(", "").Replace(")", "").ToUpper() != "E" && resposta == "5. Qual o nome do presidente do Brasil que ficou conhecido como Jango?")
            {
                Mensagem = "Errou";

                return false;
            }
            else
            {
                Mensagem = "Acertou";
                return true;
            }
        }
    }
}

