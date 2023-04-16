using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerzxt : MonoBehaviour
{
    public float speed;
    private int score = 0;
    public Text text;

    public GameObject winText;


    void Start()
    {
        

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

    private void OnTriggerEnter(Collider othere)
    {
        if(othere.tag == "Mush")
        {
            
            Destroy(othere.gameObject);
            score++;
            text.text = score.ToString();
        }
        if (score == 5)
        {
            winText.SetActive(true);
        }



    }
}


