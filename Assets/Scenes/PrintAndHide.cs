using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    [SerializeField]
    private int i;
    
    void Start()
    {
        i = 3 ;
    }

    void Update()
    {
        Debug.Log(gameObject.name + ": " + (++i) );
        
    }
}
