using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataBaseFApproach.Models
{
    public partial class UserDetail
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? NickName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Detail { get; set; } = null!;
    }
}
