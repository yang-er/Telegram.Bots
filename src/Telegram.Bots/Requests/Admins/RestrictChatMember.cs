// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

using System;
using Telegram.Bots.Types;

namespace Telegram.Bots.Requests.Admins
{
  public abstract class RestrictChatMember<TChatId> : IRequest<bool>,
    IChatMemberTargetable<TChatId>
  {
    public TChatId ChatId { get; }

    public long UserId { get; }

    public ChatPermissions Permissions { get; }

    public DateTime? UntilDate { get; set; }

    public string Method { get; } = "restrictChatMember";

    protected RestrictChatMember(TChatId chatId, long userId, ChatPermissions permissions)
    {
      ChatId = chatId;
      UserId = userId;
      Permissions = permissions;
    }
  }

  public sealed class RestrictChatMember : RestrictChatMember<long>
  {
    public RestrictChatMember(long chatId, long userId, ChatPermissions permissions) :
      base(chatId, userId, permissions) { }
  }

  namespace Usernames
  {
    public sealed class RestrictChatMember : RestrictChatMember<string>
    {
      public RestrictChatMember(string username, long userId, ChatPermissions permissions) :
        base(username, userId, permissions) { }
    }
  }
}
