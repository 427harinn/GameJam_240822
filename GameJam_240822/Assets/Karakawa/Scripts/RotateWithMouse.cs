using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    public Transform centerObject; // 回転させたい親オブジェクト
    [SerializeField] GameObject shamoji;

    private bool isDragging = false;
    private Vector3 initialShamojiPosition; // しゃもじの初期位置
    private Quaternion initialCenterRotation; // センターオブジェクトの初期回転

    void Start()
    {
        // 初期位置と回転を保存
        initialShamojiPosition = shamoji.transform.position;
        initialCenterRotation = centerObject.rotation;
    }

    void Update()
    {
        if (isDragging)
        {
            // マウスのワールド座標を取得
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Z軸は0に固定
            shamoji.transform.position = mousePosition;

            // 中心からマウス位置へのベクトルを計算
            Vector3 direction = mousePosition - centerObject.position;

            // 方向ベクトルに基づいて角度を計算
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // 中心オブジェクトのZ軸回転を設定
            centerObject.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }

    public void OnMouseDown()
    {
        // ドラッグを開始
        isDragging = true;
    }

    public void OnMouseUp()
    {
        // ドラッグを終了
        isDragging = false;

        // 初期位置と回転に戻す
        shamoji.transform.position = initialShamojiPosition;
        centerObject.rotation = initialCenterRotation;
    }
}
