// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;
using Telegram.Bots.Types;

namespace Telegram.Bots.Requests.Admins
{
  public abstract class EditChatInviteLink<TChatId> : IRequest<ChatInviteLink>,
    IChatTargetable<TChatId>
  {
    public TChatId ChatId { get; }

    public string InviteLink { get; }

    public DateTime? ExpireDate { get; set; }

    public int? MemberLimit { get; set; }

    public string Method { get; } = "editChatInviteLink";

    protected EditChatInviteLink(TChatId chatId, string inviteLink)
    {
      ChatId = chatId;
      InviteLink = inviteLink;
    }
  }

  public sealed class EditChatInviteLink : EditChatInviteLink<long>
  {
    public EditChatInviteLink(long chatId, string inviteLink) : base(chatId, inviteLink) { }
  }

  namespace Usernames
  {
    public sealed class EditChatInviteLink : EditChatInviteLink<string>
    {
      public EditChatInviteLink(string username, string inviteLink) : base(username, inviteLink) { }
    }
  }
}
