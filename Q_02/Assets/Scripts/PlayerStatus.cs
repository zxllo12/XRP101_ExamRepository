using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    float speed; // 저장할 변수를 만들어서 StackOverflowException 해결

    public float MoveSpeed // StackOverflowException 발생 MoveSpeed를 get해서 set을 반복하여 일어나는 걸로 확인됨
    {
        get => speed;
        private set => speed = value; 
    }

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        MoveSpeed = 5f;
    }
}
