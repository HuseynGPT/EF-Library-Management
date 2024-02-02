using MaterialDesignThemes.Wpf;
using MyDashboardApplication.Commands;
using Practice.DataAccess.Repositories.Concrets;
using Practice.Model.Entities.Concrets;
using System.Xml.Linq;
using System.Windows.Input;
using System.Windows;

namespace MyDashboardApplication.ViewModels.InsertPagesViewModels;

public class InsertAuthorPageViewModedl
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public ICommand InsertCommand { get; set; }

    public InsertAuthorPageViewModedl()
    {
        InsertCommand = new RelayCommand(InsertData);
    }

    private void InsertData(object? obj)
    {
        try
        {
            Author author = new ()
            {
              FirstName = FirstName,
              LastName = LastName,

            };
            AuthorRepository repo = new ();
            repo.Add(author);
            repo.Save();
        }
        catch (Exception EX)
        {

            MessageBox.Show(EX.Message);
        }
    }


}
