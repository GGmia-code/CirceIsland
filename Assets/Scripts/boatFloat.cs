using UnityEngine;
using System.Collections;

public class BoatFloat : MonoBehaviour
{
    private Vector3 originalPosition;
    public float floatAmount = 1.7f; // How much it moves
    public float floatSpeed = 2f; // How fast it moves

    void Start()
    {
        originalPosition = transform.position;
    }

    void OnMouseEnter()
    {
        StartCoroutine(FloatBoat());
    }

    void OnMouseExit()
    {
        StopAllCoroutines();
        transform.position = originalPosition;
    }

    IEnumerator FloatBoat()
    {
        while (true)
        {
            float newY = originalPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmount;
            transform.position = new Vector3(originalPosition.x, newY, originalPosition.z);
            yield return null;
        }
    }
}
