using MyDashboardApplication.Commands;
using Practice.DataAccess.Repositories.Concrets;
using Practice.Model.Entities.Concrets;
using System.Windows;
using System.Windows.Input;

namespace MyDashboardApplication.ViewModels.InsertPagesViewModels;

public class InsertBookPageViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }

    public int YearPress { get; set; }
    public string? Comment { get; set; }
    public int Quantity { get; set; }

    public int Id_Category { get; set; }
    public int Id_Author { get; set; }
    public int Id_Theme { get; set; }
    public int Id_Press { get; set; }

    public ICommand InsertCommand { get; set; }

    public InsertBookPageViewModel()
    {
        InsertCommand = new RelayCommand(InsertData);
    }

    private void InsertData(object? obj)
    {
        try
        {
            Book book = new Book()
            {
                Id = Id,
                Name = Name,
                Pages = Pages,
                YearPress = YearPress,
                Comment = Comment,
                Quantity = Quantity,
                Id_Category = Id_Category,
                Id_Author = Id_Author,
                Id_Theme = Id_Theme,
                Id_Press = Id_Press,

            };
            BookRepository bookRepository = new BookRepository();
            bookRepository.Add(book);
            bookRepository.Save();
        }
        catch (Exception EX)
        {

            MessageBox.Show(EX.Message);
        }
    }
}
