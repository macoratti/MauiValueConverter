using MauiValueConverter.Services;
using MauiValueConverter.Views;

namespace MauiValueConverter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        var services = new ServiceCollection();
        services.AddTransient<IAlunoService, AlunoService>();
        // Construir o provedor de serviços
        var serviceProvider = services.BuildServiceProvider();
        // Resolver a instância de IAlunoService
        var alunoService = serviceProvider.GetService<IAlunoService>();
        // Definie a página principal e injetar o serviço
        //MainPage = new NavigationPage(new AlunosView(alunoService));
        MainPage = new ExemploView();

    }
}
