using MauiValueConverter.Entities;
using System.Collections.ObjectModel;

namespace MauiValueConverter.Services;

public interface IAlunoService
{
    ObservableCollection<Aluno> GetAlunos();
}
