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
        Label ContadorListas = new Label();
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
            this.Titulo.Visible = false;

            this.Perguntas.Text = "1. Normalmente, quantos litros de sangue uma pessoa tem? Em média, quantos são retirados numa doação de sangue?";
            this.Alternativas.Items.Add("a) Tem entre 2 a 4 litros. São retirados 450 mililitros");
            this.Alternativas.Items.Add("b) Tem entre 4 a 6 litros. São retirados 450 mililitros");
            this.Alternativas.Items.Add("c) Tem 10 litros. São retirados 2 litros");
            this.Alternativas.Items.Add("d) Tem 7 litros. São retirados 1,5 litros");
            this.Alternativas.Items.Add("e) Tem 0,5 litros. São retirados 0,5 litros");

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
                        this.Alternativas.Items.Clear();

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
                    this.Alternativas.Items.Add("a) Platão");
                    this.Alternativas.Items.Add("b) Galileu Galilei");
                    this.Alternativas.Items.Add("c) Descartes");
                    this.Alternativas.Items.Add("d) Sócrates");
                    this.Alternativas.Items.Add("e) Francis Bacon");

                    if (this.RespostaTxt.Text != string.Empty)
                    {
                        if (RepPerguntas.SegundaPergunta(this.RespostaTxt.Text))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);
                            this.Alternativas.Items.Clear();

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
                    this.Alternativas.Items.Add("a) França");
                    this.Alternativas.Items.Add("b) Inglaterra");
                    this.Alternativas.Items.Add("c) Brasil");
                    this.Alternativas.Items.Add("d) Austrália");
                    this.Alternativas.Items.Add("e) Itália");

                    if (this.RespostaTxt.Text != string.Empty)
                    {
                        if (RepPerguntas.TerceiraPergunta(this.RespostaTxt.Text))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);
                            this.Alternativas.Items.Clear();


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
                    this.Alternativas.Items.Add("a) Vaticano e Rússia");
                    this.Alternativas.Items.Add("b) Nauru e China");
                    this.Alternativas.Items.Add("c) Mônaco e Canadá");
                    this.Alternativas.Items.Add("d) Malta e Estados Unidos");
                    this.Alternativas.Items.Add("e) São Marino e Índia");

                    if (this.RespostaTxt.Text != string.Empty)
                    {
                        if (RepPerguntas.QuartaPergunta(this.RespostaTxt.Text))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);
                            this.Alternativas.Items.Clear();


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
                    this.Alternativas.Items.Add("a) Jânio Quadros");
                    this.Alternativas.Items.Add("b) Jacinto Anjos");
                    this.Alternativas.Items.Add("c) Getúlio Vargas");
                    this.Alternativas.Items.Add("d) João Figueiredo");
                    this.Alternativas.Items.Add("e) João Goulart");

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

        private async void Alternativas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cont.Text == "0")
            {


                if (Alternativas.SelectedIndex == 1)
                {
                    cont.Text = "1";
                    if (RepPerguntas.PrimeiraPergunta(this.Alternativas.Items[1].ToString())
)
                    {
                        this.Mensagem.Text = RepPerguntas.Mensagem;
                        this.Mensagem.ForeColor = Color.Green;
                        this.Perguntas.Text = RepPerguntas.perguntas;
                        this.Mensagem.Visible = true;
                        this.RespostaTxt.Text = "";
                        this.cont.Text = "1";
                        await Task.Delay(1500);
                        this.Alternativas.Items.Clear();
                    }


                }
                else
                {
                    this.Mensagem.Text = "errou";
                    this.Mensagem.ForeColor = Color.Red;
                    this.Mensagem.Visible = true;
                }
            }

            if (cont.Text == "1")
            {

                this.Perguntas.Text = "2. De quem é a famosa frase “Penso, logo existo”?";
                this.Mensagem.Visible = false;
                this.Alternativas.Items.Add("a) Platão");
                this.Alternativas.Items.Add("b) Galileu Galilei");
                this.Alternativas.Items.Add("c) Descartes");
                this.Alternativas.Items.Add("d) Sócrates");
                this.Alternativas.Items.Add("e) Francis Bacon");

                if (ContadorListas.Text == "1")
                {

                    if (Alternativas.SelectedIndex == 2)
                    {
                        if (RepPerguntas.SegundaPergunta(this.Alternativas.Items[2].ToString()))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);
                            this.Alternativas.Items.Clear();
                            cont.Text = "2";
                        }
                    }
                    else
                    {
                        this.Mensagem.Text = "errou";
                        this.Mensagem.ForeColor = Color.Red;
                        this.Mensagem.Visible = true;
                    }
                }
                else
                {
                    ContadorListas.Text = "1";
                }
            }

            if (cont.Text == "2")
            {

                this.Perguntas.Text = "3. De onde é a invenção do chuveiro elétrico?";
                this.Mensagem.Visible = false;
                this.Alternativas.Items.Add("a) França");
                this.Alternativas.Items.Add("b) Inglaterra");
                this.Alternativas.Items.Add("c) Brasil");
                this.Alternativas.Items.Add("d) Austrália");
                this.Alternativas.Items.Add("e) Itália");

                if (ContadorListas.Text == "2")
                {

                    if (Alternativas.SelectedIndex == 2)
                    {
                        if (RepPerguntas.TerceiraPergunta(this.Alternativas.Items[2].ToString()))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);
                            this.Alternativas.Items.Clear();
                            cont.Text = "3";
                        }
                    }
                    else
                    {
                        this.Mensagem.Text = "errou";
                        this.Mensagem.ForeColor = Color.Red;
                        this.Mensagem.Visible = true;
                    }
                }
                else
                {
                    ContadorListas.Text = "2";
                }
            }

            if (cont.Text == "3")
            {
                this.Perguntas.Text = "4. Quais o menor e o maior país do mundo?";
                this.Mensagem.Visible = false;
                this.Alternativas.Items.Add("a) Vaticano e Rússia");
                this.Alternativas.Items.Add("b) Nauru e China");
                this.Alternativas.Items.Add("c) Mônaco e Canadá");
                this.Alternativas.Items.Add("d) Malta e Estados Unidos");
                this.Alternativas.Items.Add("e) São Marino e Índia");

                if (ContadorListas.Text == "3")
                {

                    if (Alternativas.SelectedIndex == 0)
                    {
                        if (RepPerguntas.QuartaPergunta(this.Alternativas.Items[0].ToString()))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);
                            this.Alternativas.Items.Clear();
                            cont.Text = "4";
                        }
                    }
                    else
                    {
                        this.Mensagem.Text = "errou";
                        this.Mensagem.ForeColor = Color.Red;
                        this.Mensagem.Visible = true;
                    }
                }
                else
                {
                    ContadorListas.Text = "3";
                }
            }

            if (cont.Text == "4")
            {
                this.Perguntas.Text = "5. Qual o nome do presidente do Brasil que ficou conhecido como Jango?";
                this.Mensagem.Visible = false;
                this.Alternativas.Items.Add("a) Jânio Quadros");
                this.Alternativas.Items.Add("b) Jacinto Anjos");
                this.Alternativas.Items.Add("c) Getúlio Vargas");
                this.Alternativas.Items.Add("d) João Figueiredo");
                this.Alternativas.Items.Add("e) João Goulart");

                if (ContadorListas.Text == "4")
                {

                    if (Alternativas.SelectedIndex == 4)
                    {
                        if (RepPerguntas.QuintaPergunta(this.Alternativas.Items[4].ToString()))
                        {
                            this.Mensagem.Text = RepPerguntas.Mensagem;
                            this.Mensagem.ForeColor = Color.Green;
                            this.Mensagem.Visible = true;
                            this.RespostaTxt.Text = "";
                            await Task.Delay(1500);
                            this.Alternativas.Items.Clear();
                            cont.Text = "5";
                            Application.Exit();
                        }
                    }
                    else
                    {
                        this.Mensagem.Text = "errou";
                        this.Mensagem.ForeColor = Color.Red;
                        this.Mensagem.Visible = true;
                    }
                }
                else
                {
                    ContadorListas.Text = "4";
                }
            }
        }
    }
}

