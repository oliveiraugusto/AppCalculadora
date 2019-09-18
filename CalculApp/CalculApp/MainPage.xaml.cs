using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculApp
{
    public partial class MainPage : ContentPage
    {
        private double valor1;
        private double valor2;
        private string operacao;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonNumero0_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "0";
        }

        private void ButtonNumero1_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "1";
        }

        private void ButtonNumero2_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "2";
        }

        private void ButtonNumero3_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "3";
        }

        private void Buttonnumero4_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "4";
        }

        private void ButtonNumero5_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "5";
        }

        private void ButtonNumero6_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "6";
        }

        private void ButtonNumero7_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "7";
        }

        private void ButtonNumero8_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "8";
        }

        private void ButtonNumero9_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "9";
        }

        private void ButtonSoma_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(entryValor.Text);
            entryValor.Text = "";
            this.operacao = "SOMA";
        }

        private void ButtonIgual_Clicked(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            this.valor2 = Convert.ToDouble(entryValor.Text);

            switch (this.operacao)
            {
                case "SOMA":                                        
                    entryValor.Text = calc.Somar(this.valor1, this.valor2).ToString();
                    break;

                case "SUBTRACAO":
                    entryValor.Text = calc.Subtrair(this.valor1, this.valor2).ToString();
                    break;

                case "DIVISAO":
                    entryValor.Text = calc.Dividir(this.valor1, this.valor2).ToString();
                    break;

                case "MULTIPLICACAO":
                    entryValor.Text = calc.Multiplicar(this.valor1, this.valor2).ToString();
                    break;

                default:
                    DisplayAlert("Ops...", "HOUVE UM ERRO!\n TENTE NOVAMENTE", "OK");
                    break;
            }
        }

        private void ButtonSubtrair_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(entryValor.Text);
            entryValor.Text = "";
            this.operacao = "SUBTRACAO";
        }

        private void ButtonLimpar_Clicked(object sender, EventArgs e)
        {
            entryValor.Text = "";
            this.valor1 = 0;
            this.valor2 = 0;
            this.operacao = "";
        }
    }
}
