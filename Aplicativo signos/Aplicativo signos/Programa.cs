using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicativo_signos
{
    public partial class Programa : Form
    {
        //Variáveis globais usadas no método QualSignoÉ.
        int DiaInserido = 0;
        int MesInserido = 0;
        string MesPalavra;

        private void QualSignoÉ()
        {
            //Array necessário para comparar os valores do dia digitado;
            int[] MesesEspecificos = new int[5]; 
            MesesEspecificos[0] = 19;
            MesesEspecificos[1] = 20;
            MesesEspecificos[2] = 21;
            MesesEspecificos[3] = 22;
            MesesEspecificos[4] = 23;

            try //Tenta executar o que está dentro.
            {
                //Converte os valores inseridos pelo usuário e os atribui a variável.
                DiaInserido = int.Parse(txtDia.Text);
                MesInserido = int.Parse(txtMes.Text);

                switch (MesInserido) 
                {
                    case 1:
                        MesPalavra = "janeiro";
                        break;
                    case 2:
                        MesPalavra = "fevereiro";
                        break;

                    case 3:
                        MesPalavra = "março";
                        break;

                    case 4:
                        MesPalavra = "abril";
                        break;

                    case 5:
                        MesPalavra = "maio";
                        break;

                    case 6:
                        MesPalavra = "junho";
                        break;

                    case 7:
                        MesPalavra = "julho";
                        break;

                    case 8:
                        MesPalavra = "agosto";
                        break;

                    case 9:
                        MesPalavra = "setembro";
                        break;

                    case 10:
                        MesPalavra = "outubro";
                        break;

                    case 11:
                        MesPalavra = "novembro";
                        break;

                    case 12:
                        MesPalavra = "dezembro";
                        break;
                }
                if ((MesInserido == 1 && DiaInserido >= 20) || (MesInserido == 2 && DiaInserido <= 18))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Aquário";
                    descSigno.Text = "Aquário é o signo ligado ao novo, ao futuro, à tecnologia, à liberdade e a tudo que é diferente. Ele veio para questionar e renovar tudo o que veio antes dele – muitas vezes, pensando em como essas mudanças afetariam a sociedade. Inovador, racional, rápido e imprevisível, ele ri da cara das regras e detesta a sensação de estar preso a algo, seja um lugar, um ideal ou uma situação.";
                    // Aquário
                }
                else if ((MesInserido == 2 && DiaInserido >= 19) || (MesInserido == 3 && DiaInserido <= 20))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Peixes";
                    descSigno.Text = "O último signo do zodíaco é profundo como um oceano e consegue navegar em dimensões aonde os mais racionais não chegam. Peixes está ligado a assuntos que envolvem introspecção, como espiritualidade, empatia, a conexão universal e o inconsciente. Esse signo vem para nos lembrar das coisas que dão um sentido maior para a vida.";
                    // Peixes
                }
                else if ((MesInserido == 3 && DiaInserido >= 21) || (MesInserido == 4 && DiaInserido <= 19))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Áries";
                    descSigno.Text = "Ariana é independente, sim, mas isso não significa que não curta a família, seja ela a de sangue ou a escolhida. Você sabe defender quem você ama, mas também não se envolve em situações para as quais não foi convidada. Sim, a sua fama é de briguenta do zodíaco, mas você não gasta sua energia com qualquer coisa, não. Isso pode fazer com que te acusem de egoísta, mas, no fim das contas, é saudável ser assim. Afinal, quando você se importa e acredita que deve ajudar, é a primeira e a mais enérgica de todos.";
                    // Áries
                }
                else if ((MesInserido == 4 && DiaInserido >= 20) || (MesInserido == 5 && DiaInserido <= 20))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Touro";
                    descSigno.Text = "Touro é o signo ligado à vida material e, por isso, podemos dizer que ele está relacionado ao seu dinheiro, à comida, posses, ao conforto e ao corpo. Touro é ouro, saiba disso, taurina. Você sabe valorizar tudo que é tátil e que ativa o seu sensorial. Você sabe enxergar a qualidade das coisas só de olhar. Sentir com as mãos também é um importante sensor de qualidade. Repare em como você vai deslizando as suas mãos pelos objetos ao passar por uma loja.";
                    // Touro
                }
                else if ((MesInserido == 5 && DiaInserido >= 21) || (MesInserido == 6 && DiaInserido <= 21))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Gêmeos";
                    descSigno.Text = "Gêmeos é um dos signos mais engraçados do zodíaco, graças ao seu raciocínio rápido e sua habilidade de enxergar as coisas de um ponto de vista mais leve. Essas qualidades fazem com que as geminianas possuam uma criatividade muito grande, no sentido de conseguirem pensar em soluções inusitadas para qualquer problema. E bota pensar nisso!";
                    // Gêmeos
                }
                else if ((MesInserido == 6 && DiaInserido >= 22) || (MesInserido == 7 && DiaInserido <= 22))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Câncer";
                    descSigno.Text = "Câncer, o signo das emoções. Se existe um signo que veio para aprender a fluir nas oscilações e na beleza dos feelings todos é esse.";
                    // Câncer
                }
                else if ((MesInserido == 7 && DiaInserido >= 23) || (MesInserido == 8 && DiaInserido <= 22))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Leão";
                    descSigno.Text = "Todo mundo conhece o clichê da descrição leonina, mas ela é a mais pura verdade: Leão brilha muito.Se você pensa que isso se traduziria em um desejo de ser famoso, pode ter razão. Mas, no caso de Leão, vamos rever esses parâmetros de sucesso. Sucesso para Leão não é aonde você chega, pois esse signo já é um sucesso só por nascer. E é aí que rola o pulo do gato, ou melhor, da leonina: por confiarem em si mesmas, as leoninas acabam arriscando mais, ousando enfrentar desafios que exigem autoconfiança e que, claro, resultam em reconhecimento e, quem sabe, fama. “A fama é óbvia, não uma busca.”";
                    // Leão
                }
                else if ((MesInserido == 8 && DiaInserido >= 23) || (MesInserido == 9 && DiaInserido <= 22))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Virgem";
                    descSigno.Text = "A maioria das virginianas se orgulha das qualidades de seu signo, pois ele é sinônimo de pragmatismo, trabalho, funcionalidade, organização e saúde, coisas que são muito bem vindas por todos nós nos dias de hoje. Significa que toda virginiana é organizada e eficiente? Não. Estamos falando da natureza do signo em seu estado perfeito, e todos nós temos o desafio de trabalhar o equilíbrio do nosso signo. A perfeição é, aliás, algo muito buscado por Virgem, e cabe a cada virginiana buscar entender o real significado disso. É sempre bom se perguntar se seus esforços estão servindo para algo que faz sentido ou se a origem de suas atitudes é mais uma obsessão que vem da mente para compensar uma inquietação interior.";
                    // Virgem
                }
                else if ((MesInserido == 9 && DiaInserido >= 23) || (MesInserido == 10 && DiaInserido <= 22))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Libra";
                    descSigno.Text = "Libra é um signo ligado ao elemento Ar e regido pelo planeta Vênus e, por isso, usa suas habilidades para trazer harmonia a tudo que a cerca através de seu talento de enxergar a mesma coisa através de muitos pontos de vista. Num conflito, a libriana sabe olhar para a situação e ver os pontos que as partes têm em comum, mostrando caminhos para o entendimento. Na casa, ela sabe quais toques dar para tudo ficar mais lindo. No look, ela consegue pensar em mil maneiras para combinar acessórios e ficar chic na festa, linda, mas sem chocar.";
                    // Libra
                }
                else if ((MesInserido == 10 && DiaInserido >= 23) || (MesInserido == 11 && DiaInserido <= 21))
                {
                    LblSigno.Show();
                    LblSigno.Text = "Escorpião";
                    // Escorpião
                }
                else if ((MesInserido == 11 && DiaInserido >= 22) || (MesInserido == 12 && DiaInserido <= 21))
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Sagitário";
                    descSigno.Text = "Escorpião é o mais indecifrável de todos os signos, e ele prefere manter as coisas assim, do jeito que estão, sob seu controle, pois seu enigmatismo lhe confere bastante poder.Escorpião tem a habilidade de ser invisível e incapturável. Escorpianas conseguem ser muito discretas, passar por lugares sem deixar rastros e envolver as pessoas de forma silenciosa e definitiva. Você pisca e de repente está se abrindo para Escorpião.";
                    // Sagitário
                }
                else
                {
                    LblSigno.Show();
                    descSigno.Show();
                    LblSigno.Text = "Capricórnio";
                    descSigno.Text = "Sagitário está ligado ao elemento Fogo e é o primeiro do grupo dos signos sociais. É o Fogo sem limites, e isso se reflete no seu jeito de olhar para o mundo. Fronteiras são apenas conceitos, vagas de estacionamento são mera marcação e objetos não têm dono, eles existem para serem compartilhados. Um misto de folgado, generoso e engraçado por natureza define.";
                    // Capricórnio (caso não se encaixe em nenhum dos intervalos anteriores)
                }
            }
            catch (FormatException ex) //Retorna a mensagem caso não consiga fazer o que está no try.
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Método responsável por mostrar o signo da pessoa.
          
        public Programa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Esconde as labels assim que o programa é iniciado.
            LblSigno.Hide(); 
            descSigno.Hide();
        }

        private void btnQualémeusig_Click(object sender, EventArgs e)
        {
            //Se os campos estiverem vazios mostrar a mensagem.
            if (txtDia.Text == string.Empty && txtMes.Text == string.Empty)
            {
                MessageBox.Show("Você precisa inserir a data antes de continuar!", "Impossível continuar", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (txtDia.Text == null || txtMes.Text == string.Empty) //Se um dos campos estiverem vazios mostrar a mensagem.
            {
                MessageBox.Show("Você deve inserir a data completa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                QualSignoÉ(); //Executa o método que mostra o signo.
            }
        }
    }
}
