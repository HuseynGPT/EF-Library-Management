using LibraryDatabase.Entities.BaseEntities;

namespace LibraryDatabase.Entities;

public class Press:BaseEnityV1
{
    public ICollection<Book> Books { get; set; }


}
