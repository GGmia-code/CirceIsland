using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public Material newSkybox; // Assign your new skybox material in the Inspector

    private void OnMouseDown() // Detects when object is clicked
    {
        if (newSkybox != null)
        {
            RenderSettings.skybox = newSkybox;
            DynamicGI.UpdateEnvironment(); // Updates lighting
        }
    }
}
