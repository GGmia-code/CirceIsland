using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject mainMenuCanvas; // Drag your Main Menu Canvas here

    public void BeginExperience()
    {
        mainMenuCanvas.SetActive(false); // Hide the menu
    }
}
