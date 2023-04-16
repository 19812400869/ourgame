using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private CharacterController playera;
    public int force = 5;
    private int score = 0;
    
public Text text;


public GameObject wintext;
    // Start is called before the first frame update
    void Start()
    {
        playera = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
       float h = Input.GetAxis("Horizontal");
float v = Input.GetAxis("Vertical");
Vector3 dir = new Vector3(h,0,v);
playera.Move(dir/2);


    }
  void OnCollisionEnter(Collision collision){
    if(collision.collider.tag == "coin"){
Destroy(collision.collider.gameObject);
    }
  }
void OnTriggerEnter(Collider collider){
  if(collider.tag == "coin"){
    
    score++;
    text.text=score.ToString();
    if(score == 10){
      wintext.SetActive(true);
    }
    Destroy(collider.gameObject);
    
  }
}

}
