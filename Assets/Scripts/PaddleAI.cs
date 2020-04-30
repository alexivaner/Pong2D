using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public float kecepatan;
    public float batasAtas;
    public float batasBawah;
    GameObject bola;
  

    float gerak;
    // Start is called before the first frame update
    void Start()
    {
        bola=GameObject.Find("Bola");
    }

    // Update is called once per frame
    void Update()
    {
        float d=bola.transform.position.y-transform.position.y;
        Debug.Log ("Ball position" +bola.transform.position.y);

        gerak=d*kecepatan*Time.deltaTime*0.8f;   

        float nextPos=transform.position.y+gerak;
        if(nextPos>batasAtas){
            gerak=0;
        }
        if(nextPos<batasBawah){
            gerak=0;
        }
        transform.Translate(0,gerak,0);
    }
}
