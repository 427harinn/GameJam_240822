using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class StartAnimScript : MonoBehaviour
{
    [SerializeField] private GameObject timer;
    [SerializeField] private GameObject[] startactiveobjects;
    [SerializeField] private float startSEWaitSeconds = 1.4f;
    // Start is called before the first frame update
    void Start()
    {
        BGMManager.Instance.Play(BGMPath.GAME_BGM);
        StartCoroutine(StartSE());
    }
    IEnumerator StartSE()
    {
        yield return new WaitForSeconds(startSEWaitSeconds);
        SEManager.Instance.Play(SEPath.START_SE);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartAnimFinish()
    {
        if (startactiveobjects.Length != 0)
        {
            foreach (GameObject startactiveobject in startactiveobjects)
            {
                startactiveobject.SetActive(true);
            }
        }
        timer.SetActive(true);
        Destroy(this.gameObject.transform.parent.gameObject);
    }
}
