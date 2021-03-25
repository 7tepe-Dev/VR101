using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    public Transform camTransform;
    Vector3 originalPosition;
    public float sallanmasuresi;
    public float sallanmamiktari;
    public float azalmamiktari;
    private void Awake()
    {
        camTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void OnEnable()
    {
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        if (sallanmasuresi > 0)
        {
            camTransform.localPosition = originalPosition + Random.insideUnitSphere * sallanmamiktari;
            sallanmasuresi = Time.deltaTime * azalmamiktari;
        }
        else
        {
            sallanmasuresi = 0;
            camTransform.localPosition = originalPosition;
        }
    }
}
