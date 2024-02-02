using LibraryDatabase.Entities.BaseEntities;

namespace LibraryDatabase.Entities;

public class Themes:BaseEnityV1
{

    public ICollection<Book> Books { get; set; }

}
