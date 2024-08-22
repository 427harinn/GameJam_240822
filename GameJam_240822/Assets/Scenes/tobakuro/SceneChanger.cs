using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadSceneA()
    {
        SceneManager.LoadScene("SceneA");
        GManager.instance.select1 = 1;
        
    }

    public void LoadSceneB()
    {
        SceneManager.LoadScene("SceneA");
        GManager.instance.select1 = 2;

    }

    public void LoadSceneC()
    {
        SceneManager.LoadScene("SceneA");
        GManager.instance.select1 = 3;

    }


}
