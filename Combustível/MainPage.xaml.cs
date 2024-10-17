namespace Combustível
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Calcular(object sender, EventArgs e)
        {
            double Alcool = Convert.ToDouble(Etanol_TXT.Text);
            double Gasolina = Convert.ToDouble(Gasolina_TXT.Text);
            string Msg = "";

            if (Alcool <= (Gasolina * 0.7)) {

                Msg = " O Etanol está compensando";


            }
            else {
                Msg = "A Gasolina está compensando";
            
            }

            DisplayAlert  ("Resultado", Msg, "Ok");

        }
    }

}
