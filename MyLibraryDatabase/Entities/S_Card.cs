using MyLibraryDatabase.Entities.BaseEnties;

namespace LibraryDatabase.Entities;

public class S_Card: BaseEntityV3
{
    public int Id_Student { get; set; }
    public Student Student { get; set; }
}
