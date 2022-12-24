using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using Microsoft.MixedReality.Toolkit;

public class HideMesh : MonoBehaviour
{

    public void hideMesh()
    {
        // Suspend Mesh Observation from all Observers
        CoreServices.SpatialAwarenessSystem.SuspendObservers();
    }

    public void resumeMesh()
    {
        // Resume Mesh Observation from all Observers
        CoreServices.SpatialAwarenessSystem.ResumeObservers();
    }

    public void removeMesh()
    {
        // Get the first Mesh Observer available, generally we have only one registered
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        // Set to not visible
        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;
    }

    public void showMesh()
    {
        // Get the first Mesh Observer available, generally we have only one registered
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        // Set to not visible
        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
    }
}
