﻿namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        string vez = "X";

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") ||
                (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") ||
                (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") ||
                (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") ||
                (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") ||
                (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") ||
                (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") ||
                (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X") ||
                (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") ||
                (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") ||
                (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") ||
                (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") ||
                (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") ||
                (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") ||
                (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") ||
                (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
            {
                DisplayAlert("Parabens", btn.Text + " GANHOU!", "Fechar");
                Zerar();
            }
           



        }//fecha Metodo

        private void Reiniciar(object sender, EventArgs e)
        {
            Zerar();
        }

        void Zerar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            vez = "X";
        }
    }//fecha Class
}//fecha NameSpace
