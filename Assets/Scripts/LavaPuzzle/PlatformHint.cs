using System.Collections;
using UnityEngine;

public class PlatformHint : MonoBehaviour
{
    Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = transform.eulerAngles;
    }
    public void RotatePlatform(float duration)
    {
        StartCoroutine(Rotate(duration));

    }
    public IEnumerator Rotate(float duration)
    {
        float startRotation = transform.eulerAngles.x;
        float endRotation = startRotation + 360.0f;
        float t = 0.0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float xRotation = Mathf.Lerp(startRotation, endRotation, t / duration) % 360.0f;
            transform.eulerAngles = new Vector3(xRotation, transform.eulerAngles.y, transform.eulerAngles.z);
            yield return null;
        }
        transform.eulerAngles = rotation;
    }

}
