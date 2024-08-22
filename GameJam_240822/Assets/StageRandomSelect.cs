using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageRandomSelect : MonoBehaviour
{
    [SerializeField] string[] stageName; 

    // Start is called before the first frame update
    void Start()
    {
        //ゲーム起動後に一回だけ実行したい
        if(GManager.instance.stageIndex != -1)
        {
            // 配列をランダムにソート
            RandomSort(stageName);

            // 結果を表示
            foreach (string str in stageName)
            {
                Debug.Log(str);
            }
            GManager.instance.stageIndex = 0;
        }

        if(stageName.Length == GManager.instance.stageIndex)
        {
            SceneManager.LoadScene("GameClear");
        }

        GManager.instance.stageIndex++;
        SceneManager.LoadScene(stageName[GManager.instance.stageIndex]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomSort(string[] array)
    {
        System.Random rng = new System.Random();
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            string value = array[k];
            array[k] = array[n];
            array[n] = value;
        }
    }
}
