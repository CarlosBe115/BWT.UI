using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWT.UI.Models
{
    public partial class Clans : BaseEntity
    {
        public Clans()
        {
            TbUserClan = new HashSet<UserClan>();
        }

        public int FkGames { get; set; }
        public string NameClan { get; set; }
        public string Abbreviation { get; set; }
        public string DescriptionClan { get; set; }
        public DateTime CreationClan { get; set; }
        public int LimitUser { get; set; }
        public int CurrentUser { get; set; }
        public string Ranked { get; set; }

        public virtual Games FkGamesNavigation { get; set; }
        public virtual ICollection<UserClan> TbUserClan { get; set; }
    }
}
