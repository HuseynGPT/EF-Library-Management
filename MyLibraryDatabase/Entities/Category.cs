using LibraryDatabase.Entities.BaseEntities;

namespace LibraryDatabase.Entities;

public class Category:BaseEnityV1
{
    public ICollection<Book> Books { get; set; }


}
