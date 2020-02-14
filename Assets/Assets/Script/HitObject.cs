using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class HitObject : MonoBehaviour
{
    
    public GameObject ThisObject;
   

    // Start is called before the first frame update
    void Start()
    {
        //Debug.LogWarning("test");
        
        

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Danger")
        {

            Debug.LogWarning("collision");

        //collectSound.Play ();
        //AudioSource.PlayClipAtPoint(clip,ThisHeart.transform.position);
            if (HealthMonitor.healthValue > 0)
            
                HealthMonitor.healthValue -= 1;

                
            ThisObject.SetActive(false);
        }




        
    }
    //void OnCollisionEnter()
    //{
    //    if(gameObject.tag == "Item")
    //    {

    //    }
    //}

   
}

