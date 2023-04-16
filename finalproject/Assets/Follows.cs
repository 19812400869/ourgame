using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follows : MonoBehaviour
{
    public Transform sjsplayerTransform;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - sjsplayerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sjsplayerTransform.position + offset;
    }
}
