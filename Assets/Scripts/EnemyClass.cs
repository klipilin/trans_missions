using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : GameClass {
    // Use this for initialization
    public float xSpeed, ySpeed;
    void Start() {
        xSpeed = (transform.localPosition.x > 0) ? -2.0F : 2.0F;
        ySpeed = (transform.localPosition.y > 0) ? -2.0F : 2.0F;        
    }
	
	// Update is called once per frame

	void Update () {
        GameObject Yoga = GameObject.FindGameObjectWithTag("player");

        if (Mathf.Abs(transform.localPosition.x) > 25.0 || Mathf.Abs(transform.localPosition.y) > 25.0)
        {            
            CreateEnemy();
            Destroy(this.gameObject);           
        }
        GetComponent<Rigidbody>()
            .MovePosition(gameObject.GetComponent<Rigidbody>().position + new Vector3(xSpeed, ySpeed, 0) * Time.deltaTime);
    }
}