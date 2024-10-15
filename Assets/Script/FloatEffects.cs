using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatEffects : MonoBehaviour
{
    public float startX = 0f;
    public float startY = 0f;
    private float duration = 1f;
    private RectTransform reactTransform;
    // Start is called before the first frame update
    void Start()
    {
        reactTransform = GetComponent<RectTransform>();
        startY = reactTransform.anchoredPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        var newY = startY + (startY + Mathf.Cos(Time.time / duration * 2)) / .1f;
        reactTransform.anchoredPosition = new Vector2(startX, newY);
    }

}
