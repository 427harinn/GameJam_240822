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
    [SerializeField] private GameObject finishObj;
    [SerializeField] private GameObject HariObject;
    private float nowRotZ = 0f;
    private float rotationSpeed = 360f / 5f; // 5秒で360度回転するための速度
    // Start is called before the first frame update
    void Start()
    {
        text= gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countdown = countdown - Time.deltaTime;
        if(nowRotZ <= 360)
        {
            //SceneManager.LoadScene("nextScene");
            float rotationThisFrame = rotationSpeed * Time.deltaTime; // 今フレームでの回転角度

            nowRotZ += rotationThisFrame; // 累積回転角度を更新（必要なら）
            HariObject.transform.Rotate(0, 0, -rotationThisFrame); // 毎フレームの回転角度を適用
        }
        

        // テキストやカウントダウンの処理
        text.text = Mathf.Ceil(countdown).ToString();

        if (countdown <= 0)
        {
            finishObj.SetActive(true);
        }
    }

}
