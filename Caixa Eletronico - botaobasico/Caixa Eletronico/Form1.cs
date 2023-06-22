namespace Caixa_Eletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             
            double saldo = 100.0;
            double valor = 110.0;
            bool podeSacar = (valor <= saldo) && (valor >=0)  ;

            if (podeSacar) { 
                saldo = saldo - valor;
                MessageBox.Show("Saque realizado com sucesso");

            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
                    }
           


            


            


        }
    }
}