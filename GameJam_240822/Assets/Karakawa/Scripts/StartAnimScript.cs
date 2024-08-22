using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimScript : MonoBehaviour
{
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
        Destroy(this.gameObject.transform.parent.gameObject);
    }
}
