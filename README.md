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


For more details about the project: [Project Thesis](francois_honours_thesis.pdf)
### Main functionalities
- Mapping
  - 3D reconstruction of landmarks of interest into 3D mesh model
  - Path creation between origin and destination using Azure Spatial Anchors
- Navigation 
  - Spatial anchors and a 3D mesh model of the destination are visualized when the user
choose the origin and destination
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

## Demo
Spatial anchors and a 3D mesh model of the destination are generated when the user choose the origin and destination.  
### Origin: Level 2 hallway, Destination: EN-2013 Visual and Analytic Computing Lab  
![](https://github.com/francelow/XRayNav/blob/main/hallway_to_visuallab.gif) 
### Origin: EN-2013 Visual and Analytic Computing Lab, Destination: Level 3  
![](https://github.com/francelow/XRayNav/blob/main/visual_lab_to_level3.gif) 
Origin: Level 3, Destination: EN-2013 Visual and Analytic Computing Lab  
![](https://github.com/francelow/XRayNav/blob/main/level3_to_visuallab.gif)

## Authors
Francois Low

In completion of Honours Thesis in partial fulfillment of the
requirements for the degree of Bachelor of Science (Honours) in Computer Science on December 2022, Memorial University of Newfoundland
