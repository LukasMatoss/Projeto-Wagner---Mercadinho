/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 09/09/2024
* Autores do Projeto: Lukas Macacari de Matos
*                     
* Turma: 2F
* Atividade Proposta em aula
* Observação: 
* textbox1 = 
* 
* problema_aula.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

    namespace Projeto_do_mercadinho
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        float ValorCompraTotal = 0; //Fica fora para o valor total da compra não resetar quando clicar no botão
        private void button1_Click(object sender, EventArgs e)
        {
            float ValorCompra = float.Parse(textBox1.Text);

            int NumeroParcelas = int.Parse(textBox2.Text);
            string DataParcelasInicial = (textBox3.Text);
            float ValorParcela = ValorCompra / NumeroParcelas;
            DateTime DataParcelasConvertida;
            DateTime DataDePagamento; //vai ser usada para comparar se a data que o caba vai pagar esta dentro ou fora do prazo das parcelas para o juros :D
            Boolean DataParcelasBool = DateTime.TryParse(DataParcelasInicial, out DataParcelasConvertida);
            int DiasUteis = 0;



            DateTime VencimentoParcela = DataParcelasConvertida.AddMonths(1); //É adicionado 1 mês a variavel vencimento parcela
            TimeSpan FuncDiferença = VencimentoParcela - DataParcelasConvertida; //TimeSpan é usado para verificar a diferença entre as datas - motivo:(dias do mes podem variar)
            int DiferençaDias = int.Parse(FuncDiferença.ToString("dd")); //Joga os valores da funcdiferença para uma variavel inteira DiferençaDias (soma de dias uteis)
            int diasAdicionados = 0;
            DataParcelasConvertida = DataParcelasConvertida.AddDays(DiferençaDias);
            while (diasAdicionados < DiferençaDias)
            {
               //resolver

                // Verificar se o dia não é sábado (6) ou domingo (0)
                if (DataParcelasConvertida.DayOfWeek != DayOfWeek.Saturday && DataParcelasConvertida.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasAdicionados++;
                }
            }
            VencimentoParcela = VencimentoParcela.AddDays(diasAdicionados);
            label8.Text = ("Dias adcionais = " + diasAdicionados); 

            for (int x = 1; x <= NumeroParcelas; x++)
            {
                textBox4.AppendText(DataParcelasConvertida.ToString("dd/MM/yyyy") + " - Valor de pagamento:  R$" + ValorParcela + " - Data de vencimento: " + VencimentoParcela.ToString("dd/MM/yyyy") + Environment.NewLine);
                ValorCompraTotal = ValorCompraTotal + ValorParcela;
            }

            label6.Text = ("Total a pagar:  R$" + ValorCompraTotal);


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
