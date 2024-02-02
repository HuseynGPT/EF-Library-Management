
using Microsoft.EntityFrameworkCore;
using Practice.DataAccess.Contexts;
using System.Collections.ObjectModel;

namespace MyDashboardApplication.ViewModels;

public class MainWindowViewModel
{

    public ObservableCollection<string> TableNames { get; set; }
    private PracticeDatabaseContext context = new();

    public MainWindowViewModel()
    {
        TableNames = new ObservableCollection<string>(GetTableNames());
    }

    public ObservableCollection<string>  GetTableNames()
    {
        return new(context.Model.GetEntityTypes().Select(e => e.Name.Substring(e.Name.LastIndexOf(".") + 1)).ToList());
    }
    
}
