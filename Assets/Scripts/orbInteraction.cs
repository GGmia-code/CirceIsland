using UnityEngine;

public class OrbInteraction : MonoBehaviour
{
    private Renderer orbRenderer;
    private Color originalColor;
    public Color hoverColor = Color.cyan;
    public Color clickedColor = Color.green;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orbRenderer = GetComponent<Renderer>();
        originalColor = orbRenderer.material.color;
    }
    void OnMouseEnter()
    {
        orbRenderer.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        orbRenderer.material.color = originalColor;
    }

    void OnMouseDown()
    {
        orbRenderer.material.color = clickedColor;
        transform.position += Vector3.up * 0.5f; // Moves the orb slightly upwards
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
