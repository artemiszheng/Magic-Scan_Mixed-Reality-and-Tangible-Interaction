using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;

public class DistanceCon : MonoBehaviour
{
    public Transform Card1;
    public Transform Card2;
    public Transform Card3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Card1.gameObject.activeSelf&& Card2.gameObject.activeSelf)
        {

            Card3.gameObject.SetActive(true);
            HideCard(Vector3.zero);
           
        }

        else
        {
            Card3.gameObject.SetActive(false);
           HideCard(new Vector3(1,1,1));
        }
    }


    void HideCard(Vector3 scale)
    {
        Card1.localScale = scale;
        Card2.localScale = scale;
    }
}