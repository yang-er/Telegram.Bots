// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace Telegram.Bots.Types
{
  public sealed class ChatMemberUpdated
  {
    public Chat Chat { get; set; } = null!;

    public User From { get; set; } = null!;

    public DateTime Date { get; set; } = DateTime.UnixEpoch;

    public ChatMember OldChatMember { get; set; } = null!;

    public ChatMember NewChatMember { get; set; } = null!;

    public ChatInviteLink? InviteLink { get; set; }
  }
}
