using System.Collections;
using UnityEngine;

public class TreeShake : MonoBehaviour
{
    private Vector3 originalRotation;

    private void Start()
    {
        originalRotation = transform.eulerAngles; // Save the tree's original rotation
    }

    private void OnMouseEnter() // When hovered
    {
        StartCoroutine(ShakeTree());
    }

    private void OnMouseExit() // When not hovered anymore
    {
        StopAllCoroutines();
        transform.eulerAngles = originalRotation; // Reset to original rotation
    }

    private IEnumerator ShakeTree()
    {
        while (true)
        {
            float shakeAmount = 3f; // Adjust how much it shakes
            transform.eulerAngles = originalRotation + new Vector3(0, 0, Mathf.Sin(Time.time * 10) * shakeAmount);
            yield return null;
        }
    }
}
