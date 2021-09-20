// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2021 Aman Agnihotri

using System;
using System.Collections.Generic;
using Telegram.Bots.Types.Games;
using Telegram.Bots.Types.Passport;
using Telegram.Bots.Types.Payments;
using Telegram.Bots.Types.Stickers;

namespace Telegram.Bots.Types
{
  public abstract class Message
  {
    public int Id { get; set; }

    public User? From { get; set; }

    public Chat? SenderChat { get; set; }

    public DateTime Date { get; set; } = DateTime.UnixEpoch;

    public Chat Chat { get; set; } = null!;

    public User? ForwardFrom { get; set; }

    public Chat? ForwardFromChat { get; set; }

    public int? ForwardFromMessageId { get; set; }

    public string? ForwardSignature { get; set; }

    public string? ForwardSenderName { get; set; }

    public DateTime? ForwardDate { get; set; }

    public Message? ReplyToMessage { get; set; }

    public User? ViaBot { get; set; }

    public DateTime? EditDate { get; set; }

    public string? AuthorSignature { get; set; }

    public InlineKeyboardMarkup? ReplyMarkup { get; set; }

    public bool IsAutomaticallyForwarded => From?.Id == 777000;

    public bool IsFromAnonymousGroupAdmin => From?.Id == 1087968824;
  }

  public abstract class CaptionableMessage : Message
  {
    public string? Caption { get; set; }

    public IReadOnlyList<MessageEntity>? CaptionEntities { get; set; }
  }

  public abstract class MediaMessage : CaptionableMessage { }

  public abstract class MediaGroupMessage : MediaMessage
  {
    public string? MediaGroupId { get; set; }
  }

  public abstract class ServiceMessage : Message { }

  public sealed class TextMessage : Message
  {
    public string Text { get; set; } = null!;

    public IReadOnlyList<MessageEntity>? Entities { get; set; }
  }

  public sealed class AnimationMessage : MediaMessage
  {
    public Animation Animation { get; set; } = null!;
  }

  public sealed class AudioMessage : MediaMessage
  {
    public Audio Audio { get; set; } = null!;
  }

  public sealed class DocumentMessage : MediaMessage
  {
    public Document Document { get; set; } = null!;
  }

  public sealed class PhotoMessage : MediaGroupMessage
  {
    public IReadOnlyList<Photo> PhotoSet { get; set; } = null!;
  }

  public sealed class StickerMessage : Message
  {
    public Sticker Sticker { get; set; } = null!;
  }

  public sealed class VideoMessage : MediaGroupMessage
  {
    public Video Video { get; set; } = null!;
  }

  public sealed class VideoNoteMessage : Message
  {
    public VideoNote VideoNote { get; set; } = null!;
  }

  public sealed class VoiceMessage : CaptionableMessage
  {
    public Voice Voice { get; set; } = null!;
  }

  public sealed class ContactMessage : Message
  {
    public Contact Contact { get; set; } = null!;
  }

  public sealed class DiceMessage : Message
  {
    public Dice Dice { get; set; } = null!;
  }

  public sealed class GameMessage : Message
  {
    public Game Game { get; set; } = null!;
  }

  public sealed class PollMessage : Message
  {
    public Poll Poll { get; set; } = null!;
  }

  public sealed class VenueMessage : Message
  {
    public Venue Venue { get; set; } = null!;
  }

  public sealed class LocationMessage : Message
  {
    public Location Location { get; set; } = null!;
  }

  public sealed class NewChatMembersMessage : Message
  {
    public IReadOnlyList<User> Members { get; set; } = null!;
  }

  public sealed class LeftChatMemberMessage : Message
  {
    public User Member { get; set; } = null!;
  }

  public sealed class NewChatTitleMessage : Message
  {
    public string Title { get; set; } = null!;
  }

  public sealed class NewChatPhotoMessage : Message
  {
    public IReadOnlyList<Photo> PhotoSet { get; set; } = null!;
  }

  public sealed class DeleteChatPhotoMessage : ServiceMessage
  {
    public bool Deleted { get; set; }
  }

  public sealed class GroupChatCreatedMessage : ServiceMessage
  {
    public bool Created { get; set; }
  }

  public sealed class SupergroupChatCreatedMessage : ServiceMessage
  {
    public bool Created { get; set; }
  }

  public sealed class ChannelChatCreatedMessage : ServiceMessage
  {
    public bool Created { get; set; }
  }

  public sealed class AutoDeleteTimerChangedMessage : ServiceMessage
  {
    public int AutoDeleteTime { get; set; }
  }

  public sealed class MigrateToChatMessage : Message
  {
    public long ChatId { get; set; }
  }

  public sealed class MigrateFromChatMessage : Message
  {
    public long ChatId { get; set; }
  }

  public sealed class PinnedMessage : Message
  {
    public Message Pinned { get; set; } = null!;
  }

  public sealed class InvoiceMessage : Message
  {
    public Invoice Invoice { get; set; } = null!;
  }

  public sealed class SuccessfulPaymentMessage : ServiceMessage
  {
    public SuccessfulPayment Payment { get; set; } = null!;
  }

  public sealed class ConnectedWebsiteMessage : Message
  {
    public Uri Website { get; set; } = null!;
  }

  public sealed class PassportDataMessage : Message
  {
    public PassportData PassportData { get; set; } = null!;
  }

  public sealed class ProximityAlertTriggeredMessage : ServiceMessage
  {
    public ProximityAlertTriggered ProximityAlertTriggered { get; set; } = null!;
  }

  public sealed class VoiceChatScheduledMessage : ServiceMessage
  {
    public VoiceChatScheduled Scheduled { get; set; } = null!;
  }

  public sealed class VoiceChatStartedMessage : ServiceMessage
  {
    public VoiceChatStarted Started { get; set; } = null!;
  }

  public sealed class VoiceChatEndedMessage : ServiceMessage
  {
    public VoiceChatEnded Ended { get; set; } = null!;
  }

  public sealed class VoiceChatParticipantsInvitedMessage : ServiceMessage
  {
    public VoiceChatParticipantsInvited ParticipantsInvited { get; set; } = null!;
  }
}
