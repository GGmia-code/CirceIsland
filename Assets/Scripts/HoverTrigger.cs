using UnityEngine;

public class HoverTrigger : MonoBehaviour
{
    public GameObject storyCanvas; // Assign Story Canvas in the Inspector

    void Start()
    {
        if (storyCanvas != null)
            storyCanvas.SetActive(false); // Hide at start
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && storyCanvas != null)
            storyCanvas.SetActive(true); // Show canvas on hover
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && storyCanvas != null)
            storyCanvas.SetActive(false); // Hide canvas when leaving
    }
}
