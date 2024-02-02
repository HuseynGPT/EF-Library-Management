using MyLibraryDatabase.Entities.BaseEnties;

namespace LibraryDatabase.Entities;

public class T_Card:BaseEntityV3
{
    public int Id_Teacher { get; set; }
    public Teacher Teacher { get; set; }

}
