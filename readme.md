<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/888577927/24.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1263358)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
## WinForms Maps - Create a Custom Search Panel Using the Microsoft Azure Maps Search Service

This example uses Microsoft’s Azure Maps Search Service to search for and obtain information on a specific map location. 

> **NOTE:**
> To incorporate this solution within your DevExpress-powered app, you need an Azure Maps service [key](https://learn.microsoft.com/en-us/azure/azure-maps/quick-demo-map-app#get-the-subscription-key-for-your-account). Replace the `AzureKey` property value with your subscription key to connect to Azure Maps.

### Implementation Details 

The original search panel is hidden. The DevExpress `TextEdit` UI element is used to specify a search keyword.  The “Search for Location” button initiates the search request. To obtain search results, our `AzureSearchDataProvider.SearchCompleted` event is raised. The `SearchCompletedEventArgs.RequestResult` method returns a `SearchRequestResult` descendant (used to store search results). Results displayed within the DevExpress `MemoEdit` element include display name, address, and geographic coordinates (latitude and longitude) for a given search location: 

Output: 

![](/image/image.png)

## Files to Look At

* [Form1.cs](./CS/AzureMapSearch/Form1.cs) 

## Documentation

* [Search](https://docs.devexpress.com/WindowsForms/16711/controls-and-libraries/map-control/gis-data/search?v=24.2)

## More Examples 

- [WinForms Maps - Obtain Information about a Geographical Point Using the Microsoft Azure Maps Geocode Service](https://github.com/DevExpress-Examples/map-for-winforms-azure-geocoding)
- [WinForms Maps - Use the Azure Maps Route Service to Calculate Routes between GeoPoints on a Map Surface](https://github.com/DevExpress-Examples/map-for-winforms-azure-routing)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-search&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-search&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
