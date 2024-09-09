<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1252015)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WinForms - Add missing fonts into DXFontRepository

You can detect and resolve fonts used in documents but are missing in your application’s hosting environment (such as various Docker images, Azure App Service, and so on). This helps you ensure that reports appear as designed, regardless of the hosting platform.

The `DXFontRepository.QueryNotFoundFont` event raises for every missing font used in documents. With event args, you can identify and resolve such missing fonts by adding them into DXFontRepository.

You can use the `e.RequestedFont` and `e.ActualFont` properties to identify fonts in the application. To add a missing font, provide a byte array that contains font data to `e.FontFileData` to add missing fonts to the `DXFontRepository` before document generation begins. 

You can add fonts from anywhere. The `FontCollectorService.cs` is an example of a custom service that asynchronously adds missing fonts from Google Fonts into `DXFontRepository`.

## Files to Review

- [FontCollectorService.cs](./CS/FontCollectorService.cs)
- [Program.cs](./CS/Program.cs)

## Documentation

- [DXFontRepository.QueryNotFoundFont](https://docs.devexpress.com/CoreLibraries/DevExpress.Drawing.DXFontRepository.QueryNotFoundFont?v=24.2)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-load-missing-fonts-from-google&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-load-missing-fonts-from-google&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
