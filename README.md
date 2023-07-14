# Microsoft Power Platform development samples
This repository contains demos and samples for Microsoft PowerApps and Power Automate, Dataverse as well as and Azure integration components and custom controls. These are basic samples showcasing the rapid business value that Power Platform solutions bring to organizations. 
Feel free to contribute and enhance and share the goodness.

## PowerApps

Contains sample apps

## SAP Integration

Contains a sample solution for Power Platform SAP integration using the SAP ERP connector. See [Readme](./SAP%20Integration/readme.md) for the SAP Truck Load Demo for contents and instructions.

## Custom Connectors

A canvas Power App to demonstrate QR code attendee scanning at events or trade fairs. Allows attendee code scanning and registering interests and call backs.
This app is part of a broader connected marketing and sales demo over Dynamics 365. A booth scan from the app will trigger a Power Automate that creates a Sales Insight card and a follow up call action for the respective sales representative.

The repo currently has the following connectors

- *Qualtrics XM* - Integrate the Qualtrics XM platform into Power Platform for surveys. Also includes a sample implemented Power Automate trigger
- *OpenAI Public* - Use the power of the public hosted OpenAI ML models. Showcases dynamics parameters and custom connector components

## Custom controls

Currently contains a sample for an Azure Maps based list view control to completely change the list view experience of a selected entity in a Model Driven App.