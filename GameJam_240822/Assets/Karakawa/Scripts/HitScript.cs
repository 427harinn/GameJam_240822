using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    [SerializeField] GameObject[] judgeobj = new GameObject[4];

    public int ordercount = 0;
    public bool isMoving = false; // しゃもじが動いているかどうかのフラグ

    private int count = 0;
    private float timeSinceLastMovement = 0f; // 最後の動きからの経過時間
    public float movementTimeout = 0.5f; // 動いていないと判断するまでの時間（秒）

    void Update()
    {
        if (count > 13)
        {
            GManager.instance.mixScore = 30;
        }
        else if (count > 10)
        {
            GManager.instance.mixScore = 20;
        }
        else if (count > 5)
        {
            GManager.instance.mixScore = 10;
        }

        // 動いている場合、時間を更新
        if (isMoving)
        {
            timeSinceLastMovement += Time.deltaTime;

            // 一定時間経過した場合、動いていないと判断
            if (timeSinceLastMovement >= movementTimeout)
            {
                isMoving = false;
                Debug.Log("しゃもじが一定時間動いていないと判断されました");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        if (other.gameObject == judgeobj[0] && ordercount == 0)
        {
            ordercount++;
            isMoving = true; // しゃもじが動いていると判定
            timeSinceLastMovement = 0f; // 経過時間をリセット
        }
        else if (other.gameObject == judgeobj[1] && ordercount == 1)
        {
            ordercount++;
            isMoving = true; // しゃもじが動いていると判定
            timeSinceLastMovement = 0f; // 経過時間をリセット
        }
        else if (other.gameObject == judgeobj[2] && ordercount == 2)
        {
            ordercount++;
            isMoving = true; // しゃもじが動いていると判定
            timeSinceLastMovement = 0f; // 経過時間をリセット
        }
        else if (other.gameObject == judgeobj[3] && ordercount == 3)
        {
            ordercount = 0;
            count++;
            isMoving = false; // しゃもじが動き終わったと判定
            timeSinceLastMovement = 0f; // 経過時間をリセット
        }
    }
}
