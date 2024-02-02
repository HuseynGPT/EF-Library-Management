using LibraryDatabase.Entities.BaseEntities;
using System.Reflection.Metadata.Ecma335;

namespace LibraryDatabase.Entities;

public class Teacher :BaseEntityV2
{

    public int Id_Dep { get; set; }
    public Department Department { get; set; }
    public ICollection<T_Card> T_Cards { get; set; }
    public Book Book{ get; set; }
}
