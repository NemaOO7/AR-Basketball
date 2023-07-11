using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class NewBehaviourScript : MonoBehaviour
{
   
    public TMP_InputField xPosition;
    public TMP_InputField size;
    void Start()
    {
       Transform transform =  GetComponent<Transform>();
    }
    void Update()
    {
        transform.localScale = new Vector3(float.Parse(size.text), float.Parse(size.text), float.Parse(size.text));
        transform.localPosition = new Vector3(float.Parse(xPosition.text), float.Parse(xPosition.text), float.Parse(xPosition.text));
    }
} 
