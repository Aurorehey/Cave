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

    void OnTriggerEnter(Collider other)
    {

        Debug.LogWarning("trigger");

        //collectSound.Play ();
        //AudioSource.PlayClipAtPoint(clip,ThisHeart.transform.position);
        if (HealthMonitor.healthValue > 0)
            HealthMonitor.healthValue -= 1;
            

        ThisObject.SetActive(false);

      
    }
}

