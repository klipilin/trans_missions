using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundClass : MonoBehaviour {

    public Object[] clouds;
    public Object[] montains;  

    // Use this for initialization

    void Start () {        
       GenerateStartPObject();
    }
	
	// Update is called once per frame
	void Update () {
        GameObject Yoga     = GameObject.FindGameObjectWithTag("player");
        transform.position  = new Vector3(Yoga.transform.position.x, Yoga.transform.position.y, 10.0F);
    }   

    public void GenerateStartPObject( )
    {
                  
        foreach (Object montain in this.montains)
        {
            for (int i = 1; i <=Random.Range(1,4); i++)
            {
                ParallaxedClass.CreatePObject(montain);
            }
        }

        foreach (Object cloud in this.clouds)
        {
            for (int i = 1; i <= Random.Range(1, 4); i++)
            {
                ParallaxedClass.CreatePObject(cloud);
            }
        }


    }
}
