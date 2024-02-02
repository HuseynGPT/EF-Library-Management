using LibraryDatabase.Entities.BaseEntities;

namespace LibraryDatabase.Entities;

public class Department:BaseEnityV1
{
    public ICollection<Teacher> Teachers { get; set; }

}
