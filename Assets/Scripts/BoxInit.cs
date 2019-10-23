﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boxObjectPrefab;
    public GameObject boxesObj;

    void Awake()
    {
        GameObject masterObj = GameObject.Find("Master");
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 5; y++) {
                GameObject g = Instantiate(boxObjectPrefab, boxesObj.transform);
                g.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f + (1.2f * x)));
                g.GetComponent<Destroyer>().masterObj = masterObj;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
