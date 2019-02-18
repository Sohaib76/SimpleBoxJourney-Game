using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;


   

    void Start()
    {
        
    }

    void Update()
    {
        float newPosition = Time.time * scrollSpeed;
        transform.position = Vector2.up * newPosition;
    }
}