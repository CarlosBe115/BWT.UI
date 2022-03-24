﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWT.UI.Models
{
    public partial class UserClan : BaseEntity
    {

        public int FkUser { get; set; }
        public int FkClan { get; set; }
        public int myRange { get; set; }
        public DateTime DateRegister { get; set; }
        public bool IsValid { get; set; }
        
        public virtual Clans FkClanNavigation { get; set; }
        public virtual UCRol FkUcrolNavigation { get; set; }
        public virtual UserInfo FkUserNavigation { get; set; }
    }
}
