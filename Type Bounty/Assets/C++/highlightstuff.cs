﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlightstuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        GetComponent<TextMesh>().color = new Color(0, 1, 0);
        GetComponent<TextMesh>().fontSize = 54;
    }

    void OnMouseExit()
    {
        GetComponent<TextMesh>().color = new Color(1, 1, 1);
        GetComponent<TextMesh>().fontSize = 42;
    }

}
