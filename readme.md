## Map for WinForms - Create a Custom Search Panel Using the Azure Maps Search Service

This example uses the Azure Maps Search Service to request for a specified location and allows users to search for a specific place on a map. 

> **NOTE:** You need a [key](https://learn.microsoft.com/en-us/azure/azure-maps/quick-demo-map-app#get-the-subscription-key-for-your-account) to use Azure Maps services in your application. Replace the `AzureKey` property value with your subscription key to connect to Azure Maps services.

The original search panel is hidden. Instead, the `TextEdit` element specify a key word that contains information to search on a map. The “Search for Location” button initiates the search request. To get search results, the `AzureSearchDataProvider.SearchCompleted` event is raised. The `SearchCompletedEventArgs.RequestResult` method returns a `SearchRequestResult` descendant that stores search results. The results displayed in the `MemoEdit` element contain a display name, address, and the geographic coordinates (latitude and longitude) associated with the search location:

![](/image/image.png)


## Files to Look At

* [Form1.cs](./CS/AzureMapSearch/Form1.cs) 

## Documentation

* [Search](https://docs.devexpress.com/WindowsForms/16711/controls-and-libraries/map-control/gis-data/search?v=24.2)

## More Examples 

