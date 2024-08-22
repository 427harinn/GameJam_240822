using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nokorijikan : MonoBehaviour
{
    public float countdown = 5f;
    public Text time;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text= gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(countdown);
        
        countdown = countdown - Time.deltaTime;
     
        //timetext.text = countdown.ToString("D1");
        text.text = Mathf.Ceil(countdown).ToString();
        if (countdown<=0)
        {
            SceneManager.LoadScene("nextScene");
        }
    }
}
