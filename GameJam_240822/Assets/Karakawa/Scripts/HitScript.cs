using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    [SerializeField] GameObject[] judgeobj = new GameObject[4];

    public int ordercount = 0;

    int count = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("count:" + count);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        if (other.gameObject == judgeobj[0] && ordercount == 0)
        {
            ordercount++;
        }
        if (other.gameObject == judgeobj[1] && ordercount == 1)
        {
            ordercount++;
        }
        if (other.gameObject == judgeobj[2] && ordercount == 2)
        {
            ordercount++;
        }
        if (other.gameObject == judgeobj[3] && ordercount == 3)
        {
            ordercount = 0;
            count++;
        }

    }
}
