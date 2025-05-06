using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("mainScene");
    }
}

