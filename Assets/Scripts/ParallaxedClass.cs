using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxedClass : MonoBehaviour {   
    public static Vector3 spawnSpot = new Vector3(0, 2, 0);
    public Object[] prefubs_variant;

    // Use this for initialization
    void Start() {
    }

    void Update()
    {
        GameObject Yoga = GameObject.FindGameObjectWithTag("player");

        if ( transform.localPosition.x > 15.0 + Yoga.transform.position.x) {           
            Object prefub = prefubs_variant[Mathf.RoundToInt( Random.Range(0, prefubs_variant.Length))];
            CreatePObject(prefub);
            Destroy(this.gameObject);
        }
        float speed = transform.localScale.x;
        transform.Translate(Vector3.right * Time.deltaTime * speed, Camera.main.transform);
    }

    public static void CreatePObject( Object prefub )
    {
        GameObject Yoga = GameObject.FindGameObjectWithTag("player");        

        float sc   = Random.value;
        float y    = Random.Range(-6.0f, 6.0f);
        float z    = 100.0F - sc + 0.1F;
        GameObject pNewObject = (GameObject)GameObject.Instantiate(prefub, new Vector3(-20.0f + Yoga.transform.position.x, y + Yoga.transform.position.y, z), Camera.main.transform.rotation) as GameObject;
        pNewObject.transform.localScale = new Vector3(sc, sc, 0);       
    }


}
