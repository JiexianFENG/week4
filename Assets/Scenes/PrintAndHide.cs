using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    [SerializeField]
    private int i;
    private int RandomNum;
    void Start()
    {
        i = 3 ;
        if (gameObject.tag == "Blue")
        {
            RandomNum = Random.Range(200, 251);
        }
        
    }

    void Update()
    {   
        
        Debug.Log(gameObject.name + ":" + (++i) );
        if (gameObject.tag == "Red" & i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" & i == RandomNum )
        {

            rend.enabled = false;
        
        }

        
    }
}
