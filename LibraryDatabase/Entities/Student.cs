using LibraryDatabase.Entities.BaseEntities;

namespace LibraryDatabase.Entities;

public class Student:BaseEntityV2
{
    public int Id_Group { get; set; }
    public Group Group { get; set; }

    public int Term { get; set; }
    public ICollection<S_Card> S_Cards { get; set; }

}
