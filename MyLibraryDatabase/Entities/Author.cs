using LibraryDatabase.Entities.BaseEntities;

namespace LibraryDatabase.Entities;

public class Author:BaseEntityV2
{
    public ICollection<Book> Books { get; set; }

}
