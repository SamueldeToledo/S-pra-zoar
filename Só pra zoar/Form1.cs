using Só_pra_zoar.Peerguntas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Só_pra_zoar
{
    public partial class PrimeiraTela : Form
    {
        Perguntas RepPerguntas = new Perguntas();

        public PrimeiraTela()
        {
            InitializeComponent();
        }

        private void PrimeiraTela_Load(object sender, EventArgs e)
        {
            this.RespostaTxt.Visible = false;
            Mensagem.Visible = false;
            this.cont.Text = "0";
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            this.RespostaTxt.Visible = true;
            this.BtnSim.Visible = false;
            this.BtnSair.Visible = false;

            this.Perguntas.Text = "1. Normalmente, quantos litros de sangue uma pessoa tem? Em média, quantos são retirados numa doação de sangue?";

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void RepostaTxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (cont.Text == "0")
                {


                    if (RepPerguntas.PrimeiraPergunta(this.RespostaTxt.Text))
                    {
                        this.Mensagem.Text = RepPerguntas.Mensagem;
                        this.Mensagem.ForeColor = Color.Green;
                        this.Perguntas.Text = RepPerguntas.perguntas;
                        this.Mensagem.Visible = true;
                        cont.Text = "1";
                        this.RespostaTxt.Text = "";
                        await Task.Delay(1500);

                    }
                    else
                    {
                        this.Mensagem.Text = RepPerguntas.Mensagem;
                        this.Mensagem.ForeColor = Color.Red;
                        this.Mensagem.Visible = true;
                    }

                }

                if (cont.Text == "1")
                {
                    this.Perguntas.Text = "2. De quem é a famosa frase “Penso, logo existo”?";
                    this.Mensagem.Visible = false;


                    if (this.RespostaTxt.Text != string.Empty)
                    {
                        if (RepPerguntas.SegundaPergunta(this.RespostaTxt.Text))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);

                            cont.Text = "2";
                        }


                        else
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Red;
                            this.Mensagem.Visible = true;

                        }
                    }
                }

                if (cont.Text == "2")
                {
                    this.Perguntas.Text = "3. De onde é a invenção do chuveiro elétrico?";
                    this.Mensagem.Visible = false;

                    if (this.RespostaTxt.Text != string.Empty)
                    {
                        if (RepPerguntas.TerceiraPergunta(this.RespostaTxt.Text))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);


                            cont.Text = "3";
                        }


                        else
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Red;
                            this.Mensagem.Visible = true;

                        }
                    }
                }

                if (cont.Text == "3")
                {
                    this.Perguntas.Text = "4. Quais o menor e o maior país do mundo?";
                    this.Mensagem.Visible = false;

                    if (this.RespostaTxt.Text != string.Empty)
                    {
                        if (RepPerguntas.QuartaPergunta(this.RespostaTxt.Text))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);


                            cont.Text = "4";
                        }


                        else
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Red;
                            this.Mensagem.Visible = true;

                        }
                    }
                }

                if (cont.Text == "4")
                {
                    this.Perguntas.Text = "5. Qual o nome do presidente do Brasil que ficou conhecido como Jango?";
                    this.Mensagem.Visible = false;

                    if (this.RespostaTxt.Text != string.Empty)
                    {
                        if (RepPerguntas.QuintaPergunta(this.RespostaTxt.Text))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);
                            Application.Exit();

                            cont.Text = "5";
                        }


                        else
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Red;
                            this.Mensagem.Visible = true;

                        }
                    }
                }



            }
        }

    }
}
