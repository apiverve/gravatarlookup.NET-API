Gravatar Lookup API
============

Gravatar Lookup is a simple tool for looking up Gravatar profiles. It returns the Gravatar profile information of the email address provided.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Gravatar Lookup API](https://apiverve.com/marketplace/api/gravatarlookup)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.GravatarLookup
```

Using the Package Manager:
```
nuget install APIVerve.API.GravatarLookup
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.GravatarLookup
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.GravatarLookup".
5. Click on the APIVerve.API.GravatarLookup package, click Install.


---

## Configuration

Before using the gravatarlookup API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Gravatar Lookup API documentation is found here: [https://docs.apiverve.com/api/gravatarlookup](https://docs.apiverve.com/api/gravatarlookup).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Gravatar Lookup API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new GravatarLookupAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new GravatarLookupQueryOptions {
  email = "hello@apiverve.com"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "profileUrl": "https://gravatar.com/apiverve",
    "thumbnailUrl": "https://0.gravatar.com/avatar/08ccd5c0bdd88b0ac13f776a4f7914db",
    "photos": [
      {
        "value": "https://0.gravatar.com/avatar/08ccd5c0bdd88b0ac13f776a4f7914db",
        "type": "thumbnail"
      }
    ],
    "displayName": "APIVerve",
    "aboutMe": "APIVerve stands out as a premier source for cloud-based API and Software-as-a-Service (SaaS) solutions catering to developers, startups and products.\n\nAt APIVerve, we take pride in being a leading provider of cutting-edge cloud-based API and Software-as-a-Service (SaaS) solutions tailored to meet the diverse needs and unlock new possibilities across various industries.",
    "currentLocation": "United States",
    "company": "APIVerve",
    "contactInfo": [
      {
        "type": "contactform",
        "value": "apiverve.com/contact"
      }
    ],
    "accounts": [
      {
        "domain": "twitter.com",
        "display": "@apivervehq",
        "url": "https://twitter.com/apivervehq",
        "iconUrl": "https://gravatar.com/icons/twitter-alt.svg",
        "is_hidden": false,
        "username": "apivervehq",
        "verified": true,
        "name": "Twitter",
        "shortname": "twitter"
      },
      {
        "domain": "github.com",
        "display": "apivervehq",
        "url": "https://github.com/apivervehq",
        "iconUrl": "https://gravatar.com/icons/github.svg",
        "is_hidden": true,
        "username": "apivervehq",
        "verified": true,
        "name": "GitHub",
        "shortname": "github"
      },
      {
        "domain": "calendly.com",
        "display": "apiverve",
        "url": "https://calendly.com/apiverve",
        "iconUrl": "https://gravatar.com/icons/calendly.svg",
        "is_hidden": false,
        "username": "calendly.com",
        "verified": true,
        "name": "Calendly",
        "shortname": "calendly"
      }
    ],
    "username": "apiverve"
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.