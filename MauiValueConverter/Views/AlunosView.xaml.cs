using MauiValueConverter.Services;

namespace MauiValueConverter.Views;

public partial class AlunosView : ContentPage
{
    private readonly IAlunoService _alunoService;
    public AlunosView(IAlunoService alunoService)
    {
        InitializeComponent();
        _alunoService = alunoService;
        lvAlunos.ItemsSource = _alunoService.GetAlunos();
    }
}