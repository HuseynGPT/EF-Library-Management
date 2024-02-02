using LibraryDatabase.Entities.BaseEntities;

namespace LibraryDatabase.Entities;

public class Group:BaseEnityV1
{
    public int Id_Faculty { get; set; }
    public Faculty Faculty { get; set; }
    public ICollection<Student> Students { get; set; }

}
