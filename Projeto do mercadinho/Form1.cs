/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 09/09/2024
* Autores do Projeto: Lukas Macacari de Matos
*                     Lucas Aguilar da Silva Nascimento
*                     
* Turma: 2F
* Atividade Projeto 3° Bimestre
* Observação:
* 
* textbox1 = Recebe o valor total da compra (um número decimal).
* textBox2 = Recebe o número total de parcelas.
* textBox3 = Recebe a data inicial das parcelas.
* textBox4 = Exibe as parcelas com as respectivas datas e valores.
* textBox5 = Recebe a data do pagamento para cálculo do reajuste das parcelas em atraso.
* button1 = Calcula o valor das parcelas e atualiza o textBox4 com as datas de vencimento e valores das parcelas. Também atualiza o label6 com o total a pagar e o label8 com os dias adicionais calculados.
* button2 = Calcula o valor reajustado das parcelas em atraso com base na data de pagamento fornecida e atualiza o textBox4 removendo a primeira linha (que seria a parcela paga). Também atualiza o label6 com o novo total a pagar.
* label6 = Exibe o total a pagar.
* label8 = Exibe o valor reajustado da parcela em atraso.
* 
* problema_aula.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_do_mercadinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float ValorCompraTotal = 0; //Fica fora para o valor total da compra não resetar quando clicar no botão
        float ValorParcela = 0;
        int diasAdicionados = 0;
        
        DateTime VencimentoParcela;
        private void button1_Click(object sender, EventArgs e)
        {
            float ValorCompra = float.Parse(textBox1.Text);
            int NumeroParcelas = int.Parse(textBox2.Text);
            string DataParcelasInicial = (textBox3.Text);
            ValorParcela = ValorCompra / NumeroParcelas;
            DateTime DataParcelasConvertida;

            Boolean DataParcelasBool = DateTime.TryParse(DataParcelasInicial, out DataParcelasConvertida);           

            VencimentoParcela = DataParcelasConvertida.AddMonths(1); //É adicionado 1 mês a variavel vencimento parcela
            TimeSpan FuncDiferença = VencimentoParcela - DataParcelasConvertida; //TimeSpan é usado para verificar a diferença entre as datas - motivo:(dias do mes podem variar)
            int DiferençaDias = int.Parse(FuncDiferença.ToString("dd")); //Joga os valores da funcdiferença para uma variavel inteira DiferençaDias (soma de dias uteis)
            diasAdicionados = 0;
            while (diasAdicionados < DiferençaDias)
            {


                // Verificar se o dia não é sábado (6) ou domingo (0)
                if (VencimentoParcela.DayOfWeek != DayOfWeek.Saturday && VencimentoParcela.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasAdicionados++;
                }
            }
           
            string ValorParcelaFormatado = String.Format("{0:F2}", ValorParcela);

            for (int x = 1; x <= NumeroParcelas; x++)
            {

                textBox4.AppendText(DataParcelasConvertida.ToString("dd/MM/yyyy") + " - Valor de pagamento:  R$" + ValorParcelaFormatado + " - Data de vencimento: " + VencimentoParcela.ToString("dd/MM/yyyy") + Environment.NewLine);
                VencimentoParcela = VencimentoParcela.AddDays(diasAdicionados);
                ValorCompraTotal = ValorCompraTotal + ValorParcela;

            }
            string ValorCompraTotalFormatado = String.Format("{0:F2}", ValorCompraTotal);
            label6.Text = ("Total a pagar: R$" + ValorCompraTotalFormatado);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // Convertendo a data de pagamento
            DateTime DataPagamentoConvertida;
            bool DataPagamentoBool = DateTime.TryParse(textBox5.Text, out DataPagamentoConvertida); // Adicione um TextBox para inserir a data de pagamento, por exemplo

            // Calculando o reajuste de parcelas em atraso
            float ValorParcelaReajustado = 0;
            DateTime DataParcelasConvertida = DateTime.Parse(textBox3.Text);
            DateTime VencimentoParcela = DataParcelasConvertida;


            
            if (DataPagamentoConvertida > VencimentoParcela)
            {
                // Calculando a diferença em meses
                int DiferençaMeses = ((DataPagamentoConvertida.Year - VencimentoParcela.Year) * 12) + DataPagamentoConvertida.Month - VencimentoParcela.Month;
                // Ajustando o valor da parcela com base no número de meses em atraso
                ValorParcelaReajustado = ValorParcela;
                for (int p = 1; p <= DiferençaMeses; p++)
                {
                    
                    ValorParcelaReajustado = ValorParcelaReajustado * 1.03f; // Reajuste de 3% por mês
                }

                string ValorParcelaReajustadoFormatado = String.Format("{0:F2}", ValorParcelaReajustado);
                label8.Text = "Parcela em atraso - Valor reajustado: R$ " + ValorParcelaReajustadoFormatado;
                
            }

            




            // Verifique se há pelo menos uma linha no textBox4
            if (textBox4.Lines.Length > 0)
            {
                // Limpe o textBox1
                

                // Crie uma nova string para armazenar o texto atualizado do textBox4
                string textoRestante = "";

                // Copie todas as linhas de textBox4, exceto a primeira, e construa o texto restante
                for (int i = 1; i < textBox4.Lines.Length; i++)
                {
                    textoRestante += textBox4.Lines[i] + Environment.NewLine;
                    
                }

                // Atualize o textBox4 com o texto restante
                textBox4.Text = textoRestante;
            }

            ValorCompraTotal = ValorCompraTotal - ValorParcela; //subtrai o valor da compra total ao pagar a parcela
            string ValorCompraTotalFormatado = String.Format("{0:F2}", ValorCompraTotal);
            label6.Text = ("Total a pagar: R$" + ValorCompraTotalFormatado);
            VencimentoParcela = VencimentoParcela.AddMonths(1); //Atualiza o mes do vencimento
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
    }
}
