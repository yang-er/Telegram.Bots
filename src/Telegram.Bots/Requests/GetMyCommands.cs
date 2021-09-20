// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2021 Aman Agnihotri

using System.Collections.Generic;
using Telegram.Bots.Types;

namespace Telegram.Bots.Requests
{
  public sealed class GetMyCommands : IRequest<IReadOnlyList<BotCommand>>
  {
    public BotCommandScope? Scope { get; set; }

    public string? LanguageCode { get; set; }

    public string Method { get; } = "getMyCommands";
  }
}
