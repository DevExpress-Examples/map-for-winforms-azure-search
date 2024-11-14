<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/888577927/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1263358)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-search&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=map-for-winforms-azure-search&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
