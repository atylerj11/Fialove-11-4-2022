using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStove : MonoBehaviour
{

    public GameObject txtToDisplay;  //display the UI text
    private bool PlayerInZone;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInZone = false; //player not in zone
        txtToDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (PlayerInZone && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("StoveTop");
        }
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
     }

     private void OnTriggerExit2D(Collider2D other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
}
