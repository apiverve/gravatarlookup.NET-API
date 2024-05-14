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

public class urls
{
    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("value")]
    public string value { get; set; }

}

public class profileBackground
{
    [JsonProperty("opacity")]
    public int opacity { get; set; }

}

public class shareflags
{
    [JsonProperty("search_engines")]
    public bool searchengines { get; set; }

}

public class data
{
    [JsonProperty("hash")]
    public string hash { get; set; }

    [JsonProperty("requestHash")]
    public string requestHash { get; set; }

    [JsonProperty("profileUrl")]
    public string profileUrl { get; set; }

    [JsonProperty("preferredUsername")]
    public string preferredUsername { get; set; }

    [JsonProperty("thumbnailUrl")]
    public string thumbnailUrl { get; set; }

    [JsonProperty("photos")]
    public photos[] photos { get; set; }

    [JsonProperty("last_profile_edit")]
    public string lastprofileedit { get; set; }

    [JsonProperty("displayName")]
    public string displayName { get; set; }

    [JsonProperty("company")]
    public string company { get; set; }

    [JsonProperty("contactInfo")]
    public contactInfo[] contactInfo { get; set; }

    [JsonProperty("urls")]
    public urls[] urls { get; set; }

    [JsonProperty("profileBackground")]
    public profileBackground profileBackground { get; set; }

    [JsonProperty("share_flags")]
    public shareflags shareflags { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
