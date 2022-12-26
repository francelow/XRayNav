# Augmented Reality indoor navigation with x-ray visualization
## Introduction
A key problem in indoor navigation is spatial awareness and wayfinding. Augmented
Reality systems can provide useful information and reduce perception load especially
in ambiguous navigation situations. One of the challenges of indoor navigation is
to locate a section of the building that is occluded by multiple layers of the interior
structure of the building in the least time possible. In this paper, we implement
an indoor navigation system on Microsoft HoloLens 2 that is capable of visualizing
occluded infrastructure directly in the user’s view of environment, thus enabling the
users to see through the walls. In order to achieve this goal, we approach the problem
with spatial mapping and x-ray visualization technique. The implemented system
contains two functionalities: Mapping and Navigation. The mapping part utilizes
Azure Spatial Anchors (ASA) to create a path from the origin to the destination and
also 3D reconstruction of the landmark into 3D mesh model using Microsoft MRTK 2
SpatialMapping API. During navigation, a pathway of spatial anchors and a 3D mesh
model of the landmark will be rendered in order to guide the user durign navigation.

[![HoloNav](https://img.youtube.com/vi/Gzxj2bzMrBU/0.jpg)](https://www.youtube.com/watch?v=Gzxj2bzMrBU)

For more details about the project, checkout our [report](francois_honours_thesis.pdf)
### Main functionalities
- Mapping
  - 3D reconstruction of landmarks of interest into 3D mesh model
  - Path creation between origin and destination using Azure Spatial Anchors
- Navigation 
  - Choose from the created anchors an origin and a destination. 
  - Generate the shortest path between these two anchors using Dijkstra’s algorithm
  - Render the navigation visualizations indicating the route
  - Two navigation visualizations supported
- User Interface (UI)
   - A hand-invoked menu that provides navigation and mapping controls
   - Teleports to the user whenever palm is raised and world locked to the 3D space when hand is dropped 

## Dependencies
### Hardware
- Microsoft HoloLens 2
### Software
- MRTK v2.5.1
- Azure Spatial Anchor SDK version 2.7.0
- Unity v2020.3.42f1
- Microsoft Visual Studio 2022 v17.4.1
- Azure Spatial Anchor SDK v2.13.3
- SpatialMapping API
- IMixedRealitySpatialAwarenessMeshObserver API

## Setup the app with API Keys
### Azure Spatial Anchor
1. To access Azure Spatial Anchor, API keys are required, which can be acquired following the tutorial [***Create Azure Spatial Anchor***](https://docs.microsoft.com/en-us/azure/spatial-anchors/quickstarts/get-started-unity-hololens?tabs=azure-portal).
2. After the access to Azure Spatial Anchor is settled, corresponding information needs to be added to the project in Unity.
  - select "Anchor Manager" from the hierarchy, populate the information in the "Spatial Anchor Manager" in the inspector
  - set the "Spatial Anchors Account Id"
  - set the "Spatial Anchors Account Key"
  - set the "Spatial Anchors Account Domain"

## Authors
Francois Low

In completion of Honours Thesis in partial fulfillment of the
requirements for the degree of Bachelor of Science (Honours) in Computer Science on December 2022, Memorial University of Newfoundland
