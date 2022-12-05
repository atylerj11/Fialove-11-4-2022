using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    private int index;
    public GameObject contButton;

    public float wordSpeed;
    public bool playerIsClose;

    public GameObject npc;
    public GameObject npcAtTable;

    public static int xcount;


    // Update is called once per frame
    void Start()
    {

        xcount = Random.Range(1, 4);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerIsClose)
        {

            if (dialoguePanel.activeInHierarchy)
            {

                zeroText();

            }
            else
            {

                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if (dialogueText.text == dialogue[index])
        {

            contButton.SetActive(true);
        }
    }

    public void zeroText()
    {

        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);

    }

    IEnumerator Typing()
    {

        foreach (char letter in dialogue[index].ToCharArray())
        {

            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);

        }
        string order = xcount.ToString();
        dialogueText.text += order;

    }

    //public void NextLine()
    //{

    //    contButton.SetActive(false);

    //    if (index < dialogue.Length)
    //    {

    //        index++;
    //        dialogueText.text = "";
    //        StartCoroutine(Typing());
    //    }
    //    else
    //    {

    //        zeroText();

    //    }

    //}



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            playerIsClose = true;


        }



    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            playerIsClose = false;
            zeroText();


        }

    }

}
