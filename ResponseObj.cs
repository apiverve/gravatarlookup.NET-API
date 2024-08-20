using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class photos
{
    [JsonProperty("value")]
    public string value { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

}

public class contactInfo
{
    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("value")]
    public string value { get; set; }

}

public class accounts
{
    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("display")]
    public string display { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("iconUrl")]
    public string iconUrl { get; set; }

    [JsonProperty("username")]
    public string username { get; set; }

    [JsonProperty("verified")]
    public string verified { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("shortname")]
    public string shortname { get; set; }

}

public class data
{
    [JsonProperty("profileUrl")]
    public string profileUrl { get; set; }

    [JsonProperty("thumbnailUrl")]
    public string thumbnailUrl { get; set; }

    [JsonProperty("photos")]
    public photos[] photos { get; set; }

    [JsonProperty("displayName")]
    public string displayName { get; set; }

    [JsonProperty("aboutMe")]
    public string aboutMe { get; set; }

    [JsonProperty("currentLocation")]
    public string currentLocation { get; set; }

    [JsonProperty("company")]
    public string company { get; set; }

    [JsonProperty("contactInfo")]
    public contactInfo[] contactInfo { get; set; }

    [JsonProperty("accounts")]
    public accounts[] accounts { get; set; }

    [JsonProperty("username")]
    public string username { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
