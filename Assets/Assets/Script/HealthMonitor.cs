using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class HealthMonitor : MonoBehaviour
{

    public  static int healthValue = 5;
    

    private Text healthText;

    public GameObject Torch;
   



    private Light lt;
   
   
    
    private RawImage torchImage1, torchImage2, torchImage3, torchImage4, torchImage5;
    
    public string MapACharger;

    public void JeRestartLeJeu()
    {

        SceneManager.LoadScene(MapACharger);
    }
    // Start is called before the first frame update
    void Start()
    {

        healthText = GameObject.Find("health").GetComponent<Text>();
        healthText.text = healthValue.ToString();

        torchImage1 = GameObject.Find("LifeImage1").GetComponent<RawImage>();
        torchImage2 = GameObject.Find("LifeImage2").GetComponent<RawImage>();
        torchImage3 = GameObject.Find("LifeImage3").GetComponent<RawImage>();
        torchImage4 = GameObject.Find("LifeImage4").GetComponent<RawImage>();
        torchImage5 = GameObject.Find("LifeImage5").GetComponent<RawImage>();
        lt = GameObject.Find("light").GetComponent<Light>();
       
        
    }


    //Update is called once per frame
    void Update()
    {
        healthText.text = healthValue.ToString();
        // adapt the size of the torch in the game
        Torch.transform.localScale = new Vector3(healthValue * 0.1f, healthValue * 0.1f, healthValue * 0.1f);
        
        // adapt the intensity of the torch light in the game
        lt.intensity = 3f * healthValue * 0.2f;
       

        // update the nr of life symbols
        if (healthValue <= 4)
            torchImage5.enabled = false;
        if (healthValue <= 3)
            torchImage4.enabled = false;
        if (healthValue <= 2)
            torchImage3.enabled = false;
        if (healthValue <= 1)
            torchImage2.enabled = false;
        if (healthValue <= 0)
        {
            torchImage1.enabled = false;
            
            //JeRestartLeJeu();

        }

        if(healthValue <= 0)
        {
            JeRestartLeJeu();
        }

       

    }
}
