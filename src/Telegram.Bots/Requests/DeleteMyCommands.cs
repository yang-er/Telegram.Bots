// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using Telegram.Bots.Types;

namespace Telegram.Bots.Requests
{
  public sealed class DeleteMyCommands : IRequest<bool>
  {
    public BotCommandScope? Scope { get; set; }

    public string? LanguageCode { get; set; }

    public string Method { get; } = "deleteMyCommands";
  }
}
