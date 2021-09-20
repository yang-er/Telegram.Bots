// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

namespace Telegram.Bots.Types
{
  public sealed class Voice : File
  {
    public int Duration { get; set; }

    public string? MimeType { get; set; }
  }
}
