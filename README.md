# Clippy Uno

Taken from an awesome project from David Packman that you can find here;

https://www.hackster.io/david-packman/clippygpt-6a683a

# What is it?

This is a CLippy that connects to my Supercharge your Data with Azure OpenAI, AI Search and Blazor.

# Setup

Create an appsettings.json file in the root and add the following;

```JSON
{
  "AzureAd": {
    "ClientId": "<Client App Registration Client ID>",
    "ClientSecret": "<Client App Registration Client Secret>",
    "TenantId": "<Tenant ID>",
    "AppIdUri": "<Web App App Registration App ID Url>"
  }
}

```

Start via SSH with;

```bash
export DISPLAY=:0
dotnet run -f net9.0-desktop
```
