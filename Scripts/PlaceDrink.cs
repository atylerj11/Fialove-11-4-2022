using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDrink : MonoBehaviour
{
    public GameObject cup;
    //private bool on = false;
    //public Vector2 spawn;


    // Start is called before the first frame update

    void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space)/* && !on*/)
        {
            //Instantiate(cup, new Vector2(4.5, -1.0542))
            cup.SetActive(true);

            //Destroy(cup, 10f);
            
            //on = true;

        }


        else if (col.gameObject.tag == "Player" && Input.GetKey(KeyCode.E))
        {

            cup.SetActive(false);
            //on = false;

        }

    }



    void Start()
    {
        cup.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
