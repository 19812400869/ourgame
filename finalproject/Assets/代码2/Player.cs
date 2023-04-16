using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
    public float speed;
    private int score = 0;
    public Text text;
    public GameObject wintext;
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere") 
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(-speed, 0f, 0f);
        }

    }
}