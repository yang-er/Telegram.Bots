// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace Telegram.Bots.Types
{
  public sealed class ChatInviteLink
  {
    public string InviteLink { get; set; } = null!;

    public User Creator { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public bool IsRevoked { get; set; }

    public DateTime? ExpireDate { get; set; }

    public int? MemberLimit { get; set; }
  }
}
