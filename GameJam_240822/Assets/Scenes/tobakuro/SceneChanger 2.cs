using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
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
        SceneManager.LoadScene("middleSelect");
        GManager.instance.select3 = "tomato";

    }

    public void LoadSceneB()
    {
        SceneManager.LoadScene("middleSelect");
        GManager.instance.select3 = "cheese";

    }

    public void LoadSceneC()
    {
        SceneManager.LoadScene("middleSelect");
        GManager.instance.select3 = "corn";

    }
}
