// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2021 Aman Agnihotri

using System;
using System.Collections.Generic;

namespace Telegram.Bots.Configs
{
  public sealed class BotConfig : IBotConfig
  {
    public Uri BaseAddress { get; set; } = new("https://api.telegram.org/");

    public string Token { get; set; } = null!;

    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(90);

    public int HandlerLifetime { get; set; } = 600;

    public IEnumerable<int> WaitsBeforeRetry { get; set; } = new[] {1, 2, 5};

    public int EventsAllowedBeforeBreaking { get; set; } = 3;

    public int BreakDuration { get; set; } = 30;
  }
}
