using LibraryDatabase.Entities.BaseEntities;

namespace LibraryDatabase.Entities;

public class Lib:BaseEntityV2
{
    public ICollection<T_Card> T_Cards { get; set; }
    public ICollection<S_Card> S_Cards { get; set; }
}
