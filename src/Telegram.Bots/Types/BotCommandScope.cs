// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

namespace Telegram.Bots.Types
{
  using Type = BotCommandScopeType;

  public abstract class BotCommandScope
  {
    public abstract BotCommandScopeType Type { get; }
  }

  public abstract class ChatBotCommandScope<TChatId> : BotCommandScope
  {
    public override BotCommandScopeType Type => Type.Chat;

    public TChatId ChatId { get; }

    protected ChatBotCommandScope(TChatId chatId) => ChatId = chatId;
  }

  public abstract class ChatAdminsBotCommandScope<TChatId> : BotCommandScope
  {
    public override BotCommandScopeType Type => Type.ChatAdministrators;

    public TChatId ChatId { get; }

    protected ChatAdminsBotCommandScope(TChatId chatId) => ChatId = chatId;
  }

  public abstract class ChatMemberBotCommandScope<TChatId> : BotCommandScope
  {
    public override BotCommandScopeType Type => Type.ChatMember;

    public TChatId ChatId { get; }

    public long UserId { get; }

    protected ChatMemberBotCommandScope(TChatId chatId, long userId)
    {
      ChatId = chatId;
      UserId = userId;
    }
  }

  public sealed class DefaultBotCommandScope : BotCommandScope
  {
    public override BotCommandScopeType Type => Type.Default;
  }

  public sealed class AllPrivateChatsBotCommandScope : BotCommandScope
  {
    public override BotCommandScopeType Type => Type.AllPrivateChats;
  }

  public sealed class AllGroupChatsBotCommandScope : BotCommandScope
  {
    public override BotCommandScopeType Type => Type.AllGroupChats;
  }

  public sealed class AllChatAdminsBotCommandScope : BotCommandScope
  {
    public override BotCommandScopeType Type => Type.AllChatAdministrators;
  }

  public sealed class ChatBotCommandScope : ChatBotCommandScope<long>
  {
    public ChatBotCommandScope(long chatId) : base(chatId) { }
  }

  public sealed class ChatAdminsBotCommandScope : ChatAdminsBotCommandScope<long>
  {
    public ChatAdminsBotCommandScope(long chatId) : base(chatId) { }
  }

  public sealed class ChatMemberBotCommandScope : ChatMemberBotCommandScope<long>
  {
    public ChatMemberBotCommandScope(long chatId, long userId) : base(chatId, userId) { }
  }

  namespace Usernames
  {
    public sealed class ChatBotCommandScope : ChatBotCommandScope<string>
    {
      public ChatBotCommandScope(string chatId) : base(chatId) { }
    }

    public sealed class ChatAdminsBotCommandScope : ChatAdminsBotCommandScope<string>
    {
      public ChatAdminsBotCommandScope(string chatId) : base(chatId) { }
    }

    public sealed class ChatMemberBotCommandScope : ChatMemberBotCommandScope<string>
    {
      public ChatMemberBotCommandScope(string chatId, long userId) : base(chatId, userId) { }
    }
  }
}
