using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    Inventaire Inventaire_Script;

    void Start()
    {
        Inventaire_Script = GameObject.Find("Inventaire").GetComponent<Inventaire>();
    }
    // Start is called before the first frame update
    public void Selection()
    {
        //Sprite du slot
        //Sprite spSlot = transform.parent.GetSiblingIndex();
        //Decremente 1 
        //Inventaire_Script.image[spSlot] -= 1;
    }

    
}
