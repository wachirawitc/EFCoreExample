using System;
using System.Collections.Generic;

namespace EFCore
{
    public partial class UserType
    {
        public UserType()
        {
            User = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
