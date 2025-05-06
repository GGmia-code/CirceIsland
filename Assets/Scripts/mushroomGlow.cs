using UnityEngine;

public class MushroomGlow : MonoBehaviour
{
    private Renderer mushroomRenderer;
    private Color originalColor;
    private float glowIntensity = 5f; // Adjust glow strength

    void Start()
    {
        mushroomRenderer = GetComponent<Renderer>();
        originalColor = mushroomRenderer.material.GetColor("_EmissionColor");
    }

    void OnMouseEnter() // When the mouse hovers over it
    {
        mushroomRenderer.material.SetColor("_EmissionColor", originalColor * glowIntensity);
    }

    void OnMouseExit() // When the mouse stops hovering
    {
        mushroomRenderer.material.SetColor("_EmissionColor", originalColor);
    }
}
