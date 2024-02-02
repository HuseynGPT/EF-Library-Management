using LibraryDatabase.Entities.BaseEntities;
using System.Text.RegularExpressions;

namespace LibraryDatabase.Entities;

public class Faculty:BaseEnityV1
{
    public ICollection<Group> Groups { get; set; }


}
