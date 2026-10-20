namespace dGomezS3.Views;

public partial class vReporte : ContentPage
{
	public vReporte(string usuario)
	{
		InitializeComponent();//
		DisplayAlertAsync("HOLA" + usuario,"Bienvenido","ok");
	}
}