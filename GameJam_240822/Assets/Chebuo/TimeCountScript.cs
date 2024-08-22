using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCountScript : MonoBehaviour
{
    public float count = 15;
    Text scoreText;
    [SerializeField] string loadSceneName = "StageSelectScene";
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        count -= Time.deltaTime;
        scoreText.text = (int)count + "";

        if(count <= 0)
        {
            SceneManager.LoadScene(loadSceneName);
        }


    }
}
