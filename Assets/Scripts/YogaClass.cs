using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YogaClass : MonoBehaviour {

    public float yogaSpeed = 4.0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameClass.ChangeDzen(.05F * Time.deltaTime);

        if (Input.GetKey("up")) {
            GetComponent<Rigidbody>()
               .MovePosition(gameObject.GetComponent<Rigidbody>().position + new Vector3(0, yogaSpeed, 0) * Time.deltaTime);
            GameClass.ChangeDzen(-1.0F * Time.deltaTime);
        }

        if (Input.GetKey("right")) {
            GetComponent<Rigidbody>()
                .MovePosition(gameObject.GetComponent<Rigidbody>().position + new Vector3(yogaSpeed, 0, 0) * Time.deltaTime);
            GameClass.ChangeDzen(-1.0F * Time.deltaTime);
        }

        if (Input.GetKey("down")) {
            GetComponent<Rigidbody>()
                .MovePosition(gameObject.GetComponent<Rigidbody>().position + new Vector3(0, -1.0F * yogaSpeed, 0) * Time.deltaTime);

            GameClass.ChangeDzen(-1.0F * Time.deltaTime);
        }

        if (Input.GetKey("left")) {
            GetComponent<Rigidbody>()
               .MovePosition(gameObject.GetComponent<Rigidbody>().position + new Vector3(-1.0F * yogaSpeed, 0, 0) * Time.deltaTime);

            GameClass.ChangeDzen(-1.0F * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {       
        GetComponent<Animation>().Play("yoga_collizium_anim");
    }

    void OnTriggerEnter(Collider other)
    {       
        GameClass.ChangeDzen(-10.0F * Time.deltaTime);
    }

}
