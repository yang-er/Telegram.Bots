// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2021 Aman Agnihotri

namespace Telegram.Bots.Types.Inline
{
  public sealed class InlineQuery
  {
    public string Id { get; set; } = null!;

    public User From { get; set; } = null!;

    public string Query { get; set; } = null!;

    public string Offset { get; set; } = null!;

    public ChatType? ChatType { get; set; }

    public Location? Location { get; set; }
  }
}
