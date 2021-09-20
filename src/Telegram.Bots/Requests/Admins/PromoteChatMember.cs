// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2021 Aman Agnihotri

namespace Telegram.Bots.Requests.Admins
{
  public abstract class PromoteChatMember<TChatId> : IRequest<bool>, IChatMemberTargetable<TChatId>
  {
    public TChatId ChatId { get; }

    public long UserId { get; }

    public bool? IsAnonymous { get; set; }

    public bool? CanManageChat { get; set; }

    public bool? CanChangeInfo { get; set; }

    public bool? CanPostMessages { get; set; }

    public bool? CanEditMessages { get; set; }

    public bool? CanDeleteMessages { get; set; }

    public bool? CanManageVoiceChats { get; set; }

    public bool? CanInviteUsers { get; set; }

    public bool? CanRestrictMembers { get; set; }

    public bool? CanPinMessages { get; set; }

    public bool? CanPromoteMembers { get; set; }

    public string Method { get; } = "promoteChatMember";

    protected PromoteChatMember(TChatId chatId, long userId)
    {
      ChatId = chatId;
      UserId = userId;
    }
  }

  public sealed class PromoteChatMember : PromoteChatMember<long>
  {
    public PromoteChatMember(long chatId, long userId) : base(chatId, userId) { }
  }

  namespace Usernames
  {
    public sealed class PromoteChatMember : PromoteChatMember<string>
    {
      public PromoteChatMember(string username, long userId) : base(username, userId) { }
    }
  }
}
