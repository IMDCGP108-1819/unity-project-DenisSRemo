using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorite : MonoBehaviour {

    public float speed;
    private float StartTime;
    public float delaytime;
    public float LifeTime;
    public Vector3 StartingPosition;
    void Start () {
        StartingPosition = gameObject.transform.position;
        StartTime = Time.time;
    }
	
	//movement of the meteorite
	void Update () {
        transform.position += -transform.right * speed;

        if (Time.time >= StartTime + LifeTime)
        {
            gameObject.SetActive(false);
            gameObject.transform.position = StartingPosition;
            gameObject.SetActive(true);
            StartTime = Time.time;
            speed = speed + speed / 100000;
        }
        
	}
   
    
}
