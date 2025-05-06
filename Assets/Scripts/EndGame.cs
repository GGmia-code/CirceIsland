using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Canvas endScreenCanvas; // Drag the End Screen Canvas here

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("0");

        if (other.CompareTag("Player")) // Make sure the Player has the correct tag
        {
            Debug.Log("1");
            endScreenCanvas.enabled = true;
        }
    }
}
