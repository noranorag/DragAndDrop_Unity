using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laiks : MonoBehaviour {

    //nosaka laiku

    public Objekti objektuSkripts;
    void Update()
    {
        if (objektuSkripts.laiksOn == true)
        {
            objektuSkripts.laiks += Time.deltaTime;
        }
    }
}
