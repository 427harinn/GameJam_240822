using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_S2 : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    private Vector3 movement;

    void Update()
    {
        // 入力を受け取る
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // ベクトル正規化
        movement = movement.normalized;

        // transform.positionに加算
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
