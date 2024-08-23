using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtoScript : MonoBehaviour
{
    [SerializeField] GameObject howobj;
    [SerializeField] GameObject[] discriptions = new GameObject[10];
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(count);
    }

    public void onClicked_how()
    {
        howobj.SetActive(true);
    }

    public void onClicked_nextobj()
    {
        if (discriptions.Length != count)
        {
            discriptions[count].SetActive(true);
            if (count != 0)
            {
                discriptions[count - 1].SetActive(false);
            }
        }
        else
        {
            discriptions[count - 1].SetActive(false);
            discriptions[0].SetActive(true);
            count = 0;
            howobj.SetActive(false);
        }
        count++;
    }

    public void onClicked_closebutton()
    {
        discriptions[0].SetActive(true);
        if (count != 0)
        {
            discriptions[count - 1].SetActive(false);
        }

        count = 1;
        howobj.SetActive(false);
    }
}
