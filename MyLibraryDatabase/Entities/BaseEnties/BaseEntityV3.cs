using LibraryDatabase.Entities;

namespace MyLibraryDatabase.Entities.BaseEnties;

public class BaseEntityV3
{
    public int Id { get; set; }
    public int Id_Book { get; set; }
    public Book Book { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int Id_Lib { get; set; }
    public Lib Lib { get; set; }
}
