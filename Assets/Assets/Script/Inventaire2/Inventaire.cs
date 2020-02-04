using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Inventaire : MonoBehaviour
{
    bool activation = false;
    //public GameObject Player;
    GameObject ObjetarecupererImageGraphi;
    public Sprite[] image;


    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        ObjetarecupererImageGraphi = transform.GetChild(0).gameObject;
        image = new Sprite[ObjetarecupererImageGraphi.transform.childCount];
    }
   
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activation = !activation;

            //if (!activation)
            //{
            //    Player.GetComponent<ThirdPersonController> ().enabled = true;
            //}
            //else
            //{
            //    Player.GetComponent<ThirdPersonController> ().enabled = false;
            //    Cursor.lockState = CursorLockMode.None;
            //    Cursor.visible = true;
            //}

            GetComponent<Canvas>().enabled = activation;

        }

    }

    
}
  