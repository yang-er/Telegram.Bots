// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2021 Aman Agnihotri

using System.Collections.Generic;
using Telegram.Bots.Types.Payments;

namespace Telegram.Bots.Types.Inline
{
  public abstract class InputContent
  {
  }

  public sealed class ContactContent : InputContent
  {
    public string PhoneNumber { get; }

    public string FirstName { get; }

    public string? LastName { get; set; }

    public string? Vcard { get; set; }

    public ContactContent(string phoneNumber, string firstName)
    {
      PhoneNumber = phoneNumber;
      FirstName = firstName;
    }
  }

  public sealed class LocationContent : InputContent
  {
    public double Latitude { get; }

    public double Longitude { get; }

    public double? HorizontalAccuracy { get; set; }

    public int? LivePeriod { get; set; }

    public uint? Heading { get; set; }

    public uint? ProximityAlertRadius { get; set; }

    public LocationContent(double latitude, double longitude)
    {
      Latitude = latitude;
      Longitude = longitude;
    }
  }

  public sealed class TextContent : InputContent
  {
    public string Text { get; }

    public ParseMode? ParseMode { get; set; }

    public IEnumerable<MessageEntity>? Entities { get; set; }

    public bool? DisableWebPagePreview { get; set; }

    public TextContent(string text) => Text = text;
  }

  public sealed class VenueContent : InputContent
  {
    public string Title { get; }

    public string Address { get; }

    public double Latitude { get; }

    public double Longitude { get; }

    public string? FoursquareId { get; set; }

    public string? FoursquareType { get; set; }

    public string? GooglePlaceId { get; set; }

    public string? GooglePlaceType { get; set; }

    public VenueContent(string title, string address, double latitude, double longitude)
    {
      Title = title;
      Address = address;
      Latitude = latitude;
      Longitude = longitude;
    }
  }

  public sealed class InvoiceContent : InputContent
  {
    public string Title { get; }

    public string Description { get; }

    public string Payload { get; }

    public string ProviderToken { get; }

    public string Currency { get; }

    public IEnumerable<LabeledPrice> Prices { get; }

    public int? MaxTipAmount { get; set; }

    public IEnumerable<int>? SuggestedTipAmounts { get; set; }

    public string? ProviderData { get; set; }

    public string? PhotoUrl { get; set; }

    public int? PhotoSize { get; set; }

    public int? PhotoWidth { get; set; }

    public int? PhotoHeight { get; set; }

    public bool? NeedName { get; set; }

    public bool? NeedPhoneNumber { get; set; }

    public bool? NeedEmail { get; set; }

    public bool? NeedShippingAddress { get; set; }

    public bool? SendPhoneNumberToProvider { get; set; }

    public bool? SendEmailToProvider { get; set; }

    public bool? IsFlexible { get; set; }

    public InvoiceContent(
      string title,
      string description,
      string payload,
      string providerToken,
      string currency,
      IEnumerable<LabeledPrice> prices)
    {
      Title = title;
      Description = description;
      Payload = payload;
      ProviderToken = providerToken;
      Currency = currency;
      Prices = prices;
    }
  }
}
