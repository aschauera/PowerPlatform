# Microsoft Business Application & Power Platform development samples
This repository contains demoa and samples for Microsoft PowerApps/Flow, CDS and Azure. These are basic samples showcasing the rapid business value that Power Platform solutions bring to organizations. 
Feel free to contribute and enhance and share the goodness.

## Smart 0 waste

End2End sample PowerApp showcasing how to leverage AI Builder object detection models to detect coffee capsules spilled in a production line. Includes manual reporting with camera control and report button, as well as simulation of automated image capturing (e.g. once a second via fixed camera).
Manual reporting works over the built in AI builder control for object detection in the PowerApp and with CDS and creates a new "Spill" entity. A Power Automate is listening on creation of "Spill" entities to implement a notification workflow.
Automated reporting calls a PowerAutomate once a second and analyzes the images using the AI builder object detection model in Power Automate, thus achieving parallel, asynchronous processing of incoming images.

The solution consists of the following components

- *Smart 0 waste* - Canvas Power App
- *Nespresso Capsule* - CDS entity
- *Spill* - CDS entity
- *Record and analyze capsule spill* - Automated reporting Power Automate

### Known issues

- Existing accessibility warnings in Canvas App - please allow time some more time to fix these.
- AI builder model needs rebuilding due to using preview functionality

## Smart Fair

A canvas Power App to demonstrate QR code attendee scanning at events or trade fairs. Allows attendee code scanning and registering interests and call backs.
This app is part of a broader connected marketing and sales demo over Dynamics 365. A booth scan from the app will trigger a Power Automate that creates a Sales Insight card and a follow up call action for the respective sales representative.

The solution consists of the following components

- *Smart fair* - Canvas Power App for tablet layout
- *Create booth checkin* - Power automate to create sales insights card and phone activity

## Smart Repair

