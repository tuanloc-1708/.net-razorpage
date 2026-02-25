using System;
using System.Collections.Generic;

namespace MyStore.Business.LocNT;

public partial class AccountMember
{
    public string MemberId { get; set; } = null!;

    public string MemberPassword { get; set; } = null!;

    public string? FullName { get; set; }

    public string? EmailAddress { get; set; }

    public string? MemberRole { get; set; }
}
