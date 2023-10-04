using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    private Vector3 originalScale;
    private bool scalingUp = true;
    private int scalingSize = 4;
    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.localScale == originalScale * scalingSize)
        {
            scalingUp = false;
        }
        if (transform.localScale == originalScale)
        {
            scalingUp = true;
        }

        Vector3 scalingTo4x = Vector3.MoveTowards(transform.localScale, originalScale * scalingSize, Time.deltaTime);
        Vector3 scalingToOriginal = Vector3.MoveTowards(transform.localScale, originalScale, Time.deltaTime);

        transform.localScale = scalingUp ? scalingTo4x : scalingToOriginal;
    }
}
