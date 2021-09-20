// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2021 Aman Agnihotri

using System;

namespace Telegram.Bots.Requests.Admins
{
  public abstract class BanChatMember<TChatId> : IRequest<bool>, IChatMemberTargetable<TChatId>
  {
    public TChatId ChatId { get; }

    public long UserId { get; }

    public DateTime? UntilDate { get; set; }

    public bool? RevokeMessages { get; set; }

    public string Method { get; } = "banChatMember";

    protected BanChatMember(TChatId chatId, long userId)
    {
      ChatId = chatId;
      UserId = userId;
    }
  }

  public sealed class BanChatMember : BanChatMember<long>
  {
    public BanChatMember(long chatId, long userId) : base(chatId, userId) { }
  }

  namespace Usernames
  {
    public sealed class BanChatMember : BanChatMember<string>
    {
      public BanChatMember(string username, long userId) : base(username, userId) { }
    }
  }
}
