using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimScript : MonoBehaviour
{
    [SerializeField] GameObject timer;
    [SerializeField] GameObject startactiveobj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartAnimFinish()
    {
        startactiveobj.SetActive(true);
        timer.SetActive(true);
        Destroy(this.gameObject.transform.parent.gameObject);
    }
}
