using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string MapACharger;
    public void JeRestartLeJeu()
    {
        SceneManager.LoadScene(MapACharger);
    }
}
