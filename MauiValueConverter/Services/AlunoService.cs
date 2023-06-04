using MauiValueConverter.Entities;
using System.Collections.ObjectModel;

namespace MauiValueConverter.Services;

public class AlunoService : IAlunoService
{
    private ObservableCollection<Aluno> alunos;
    public ObservableCollection<Aluno> GetAlunos()
    {
         alunos = new ObservableCollection<Aluno>
         {
           new Aluno { Nome = "Maria", Nota = 9.3 },
           new Aluno { Nome = "Paulo", Nota = 7.8 },
           new Aluno { Nome = "Sandra", Nota = 5.5 },
           new Aluno { Nome = "Carlos", Nota = 5.9 },
           new Aluno { Nome = "Silvia", Nota = 8.4 },
           new Aluno { Nome = "Jaime", Nota = 7.5 },
           new Aluno { Nome = "Debora", Nota = 5.3 },
           new Aluno { Nome = "Elena", Nota = 7.4 }
         };
        return alunos;
    }
}
