# A document classification solution using Microsoft Power Platform

This folder contains the document intelligence solution as described in the LinkedIn post [here](https://www.linkedin.com/pulse/towards-fully-automated-document-intake-power-andreas-aschauer-0psqf)

## Building and deploying

### Prerequisites

- [Power Platform CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction?tabs=windows)


Using PAC ClI make sure you are connected to the correct tenant/environment

```
pac auth create --environment <Your environment ID>
```
Clone the repository into a local folder, build and deploy
```
> git clone https://github.com/aschauera/PowerPlatform.git
> cd .\AI\AADocumentIntelligencePublic\
> pac solution pack --zipfile DocIntelligence.zip --folder .\src\  
> pac solution import --path .\DocIntelligence.zip
```
