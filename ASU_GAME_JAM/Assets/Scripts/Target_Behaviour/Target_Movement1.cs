using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Target_Movement1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 1f;
    [SerializeField] private float endPoint = 8f;
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(endPoint, transform.position.y), speed * Time.deltaTime);
    }
}
