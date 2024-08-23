using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniFinishScript : MonoBehaviour
{
    [SerializeField] GameObject nextbutton;
    [SerializeField] GameObject finishInactiveobj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AnimFinish()
    {
        if (finishInactiveobj != null)
        {
            finishInactiveobj.SetActive(false);
        }

        nextbutton.SetActive(true);
    }
}
