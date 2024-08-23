using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    [SerializeField] GameObject fade;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClicked_start()
    {
        fade.SetActive(true);
        Invoke("start", 1.0f);
    }

    void start()
    {
        SceneManager.LoadScene("CutSelect");
    }
}
