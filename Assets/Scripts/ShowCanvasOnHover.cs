using UnityEngine;

public class ShowCanvasOnHover : MonoBehaviour
{
    public GameObject storyCanvas; // Assign the Story Canvas in the Inspector

    void Start()
    {
        if (storyCanvas != null)
            storyCanvas.SetActive(false); // Ensure it starts hidden
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && storyCanvas != null)
            storyCanvas.SetActive(true); // Show canvas when player is near
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && storyCanvas != null)
            storyCanvas.SetActive(false); // Hide canvas when player leaves
    }
}
