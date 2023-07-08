namespace TDMPW_412_PR04;

public partial class PaginaFem : ContentPage
{
	public PaginaFem()
	{
		InitializeComponent();
	}

    void btnCalcularIMCFem_Clicked(System.Object sender, System.EventArgs e)
    {
        double peso = 0;
        double altura = 0;
        double imc = 0;
        string resultadoEnTexto = "";

        try
        {
            peso = double.Parse(txtPesoF.Text);
            altura = double.Parse(txtTallaF.Text);
            imc = peso / (Math.Pow(altura, 2));

            if (imc < 18.5)
            {
                resultadoEnTexto = (Math.Round(imc, 1) + " : peso inferior al normal.").ToString();
            }
            else if (imc < 24.9)
            {
                resultadoEnTexto = (Math.Round(imc, 1) + " : peso normal.").ToString();
            }
            else if (imc < 29.9)
            {
                resultadoEnTexto = (Math.Round(imc, 1) + " : peso superior al normal.").ToString();
            }
            else
            {
                resultadoEnTexto = (Math.Round(imc, 1) + " : obesidad").ToString();
            }

            lblResFem.Text = resultadoEnTexto;
        }
        catch (Exception)
        {
            lblResFem.Text = "Ingresa un valor válido";
        }

        
    }

}
