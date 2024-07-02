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
            if (resposta.Replace(" ", "").ToUpper() != "4A6LITROS")
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


            if (resposta.Replace(" ", "").ToUpper() != "DESCARTES")
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


            if (resposta.Replace(" ", "").ToUpper() != "BRASIL")
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


            if (resposta.Replace(" ", "").ToUpper() != "VATICANOERUSSIA")
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


            if (resposta.Replace(" ", "").ToUpper() != "JOAOGOULART")
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

