using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClass : MonoBehaviour {
    public Object[] enemies;
    public float respaun = 10.0F;

    public static bool activeGame = true;

    // Use this for initialization
    void Start () {
        GetComponent<AudioSource>().Play();
        CreateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Yoga = GameObject.FindGameObjectWithTag("player");
        GameObject.FindGameObjectWithTag("hud").transform.position = new Vector3(Yoga.transform.position.x-5.0F, Yoga.transform.position.y, 10.0F);

        Camera.main.transform.position = new Vector3(Yoga.transform.position.x, Yoga.transform.position.y, -10.0F);
    }
    public static void ChangeDzen(float dzen) {
        if (activeGame) {
           
            GameObject hudFull = GameObject.FindGameObjectWithTag("hud_full");           
            if ((hudFull.transform.localScale.y + dzen) <= 0)
            {
                Debug.Log("Win");
                hudFull.transform.localScale = new Vector3(0, 0, 0);
                GameObject.FindGameObjectWithTag("tm_failed").GetComponent<SpriteRenderer>().enabled = true;
                activeGame = false;
            }
            else if ((hudFull.transform.localScale.y + dzen) >= 1)
            {
                Debug.Log("You die");
                GameObject.FindGameObjectWithTag("tm_completed").GetComponent<SpriteRenderer>().enabled = true;
                activeGame = false;              
            }
            else
            {
                hudFull.transform.localScale += new Vector3(0, dzen, 0);
            }
        }
    }

    

    public void CreateEnemy() {
        float y, x;
        for (int i = 1; i <= Random.Range(1, 3); i++)
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    y = respaun;
                    x = Random.Range(-1.0F * respaun, respaun);
                    break;
                case 2:
                    y = Random.Range(-1.0F * respaun, respaun);
                    x = respaun;
                    break;
                case 3:
                    y = -1.0F * respaun;
                    x = Random.Range(-1.0F * respaun, respaun);
                    break;
                case 4:
                    y = Random.Range(-1.0F * respaun, respaun);
                    x = -1.0F * respaun;
                    break;
                default:
                    y = -1.0F * respaun;
                    x = Random.Range(-1.0F * respaun, respaun);
                    break;
            }

            GameObject Yoga = GameObject.FindGameObjectWithTag("player");

            Object prefub           = enemies[Mathf.RoundToInt(Random.Range(0, enemies.Length))];
            GameObject pNewObject   = (GameObject)GameObject.Instantiate(prefub, new Vector3(x + Yoga.transform.position.x, y + Yoga.transform.position.y, 0), Camera.main.transform.rotation) as GameObject;
        }
    }
}