using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automove : MonoBehaviour
{
    public float moveSpeed = 4f; // 오브젝트 이동 속도
    private bool movingRight = true; // 오브젝트의 이동 방향
    public float leftlimit = 0.0f;
    public float rightlimit = 0.0f;
    void Update()
    {
        // 이동 방향에 따라 오브젝트를 이동시킴
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime); // 오른쪽으로 이동
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime); // 왼쪽으로 이동
        }

        // 화면 끝에 도달하면 방향을 바꿈
        if (transform.position.x >= rightlimit) // 오른쪽 끝에 도달했을 때
        {
            movingRight = false;
        }
        else if (transform.position.x <= leftlimit) // 왼쪽 끝에 도달했을 때
        {
            movingRight = true;
        }
    }
}