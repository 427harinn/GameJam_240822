using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using KanKikuchi.AudioManager;

public class MiniFinishScript : MonoBehaviour
{
    [SerializeField] GameObject nextbutton;
    [SerializeField] GameObject[] finishInactiveobjects;
    GameObject finishInactiveobj;
    [SerializeField] string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        SEManager.Instance.Play(SEPath.TIN);
        BGMManager.Instance.Stop();
        if (finishInactiveobjects.Length == 0) return;
        foreach (GameObject finishInactiveobj in finishInactiveobjects)
        {
            finishInactiveobj.SetActive(false);
        }
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
    public void OnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
