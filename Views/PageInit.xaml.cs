namespace Maui3P2024UTH.Views;

public partial class PageInit : ContentPage
{
	public PageInit()
	{
		InitializeComponent();
	}

    private async void btnagregar_Clicked(object sender, EventArgs e)
    {
		var person = new Models.Personas
		{
			Nombres = nombres.Text,
			Apellido= apellidos.Text,
			Fecha = Fecha.Date,
			Telefono = telefono.Text

        };

		if (await App.DataBase.StorePerson(person) > 0)
		{
			await DisplayAlert("Aviso", "Registo agregado con exito", "OK");
		}

	//	var pagina = new Views.PageDetalle();
	//	pagina.BindingContext = person;
	//	await Navigation.PushAsync( pagina );


		//await DisplayAlert("Aviso", "Hola", "ok");
    }
}