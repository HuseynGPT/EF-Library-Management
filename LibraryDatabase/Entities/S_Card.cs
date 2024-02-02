namespace LibraryDatabase.Entities;

public class S_Card
{

    public int Id { get; set; }
    public int Id_Student { get; set; }
    public int Id_Book { get; set; }

    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int Id_Lib { get; set; }
}
