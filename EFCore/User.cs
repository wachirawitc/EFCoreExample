using System;
using System.Collections.Generic;

namespace EFCore
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }
    }
}
