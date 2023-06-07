using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

    //Ielade sakuma ekranu
    
    public void uzSakumu()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    //Ielade pašu spēli

    public void uzPilsetasAina()
    {
        SceneManager.LoadScene("PilsetasAina", LoadSceneMode.Single);
    }

    //Aizver programmu

    public void Apturet()
    {
        Application.Quit();
    }

}
