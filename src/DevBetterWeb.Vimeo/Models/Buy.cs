﻿using System.Text.Json.Serialization;
using System;
namespace DevBetterWeb.Vimeo.Models
{

  public class Buy
  {
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("display_price")]
    public string DisplayPrice { get; set; }

    [JsonPropertyName("download")]
    public string Download { get; set; }

    [JsonPropertyName("drm")]
    public bool Drm { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("price")]
    public double Price { get; set; }

    [JsonPropertyName("purchase_time")]
    public DateTime PurchaseTime { get; set; }

    [JsonPropertyName("stream")]
    public string Stream { get; set; }

    [JsonPropertyName("uri")]
    public string Uri { get; set; }
  }

}
