using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public Transform centerObject; // 赤い丸の中心
    public float radius = 3f; // 赤い丸の半径
    public float moveInterval = 0.5f; // 四角形が移動する時間間隔（秒）

    private float timer = 0f;
    public HitScript hitScript; // HitScript への参照

    void Start()
    {
        moveInterval = 0f + Random.Range(0.3f, 1f);
    }

    void Update()
    {
        // しゃもじが動いている間のみ移動処理を行う
        if (hitScript.isMoving)
        {
            // タイマーを更新
            timer += Time.deltaTime;

            // 一定時間が経過したら四角形を移動
            if (timer >= moveInterval)
            {
                MoveToRandomPosition();
                moveInterval = 0f + Random.Range(0.3f, 1f);
                timer = 0f; // タイマーをリセット
            }
        }
    }

    void MoveToRandomPosition()
    {
        // ランダムな角度を計算
        float angle = Random.Range(0f, 360f);
        float radian = angle * Mathf.Deg2Rad;

        // ランダムな半径内の位置を計算
        float randomRadius = Random.Range(0f, radius);
        Vector3 randomPosition = new Vector3(
            Mathf.Cos(radian) * randomRadius,
            Mathf.Sin(radian) * randomRadius,
            0f
        );

        // 中心からのオフセットで位置を設定
        transform.position = centerObject.position + randomPosition;
    }
}
