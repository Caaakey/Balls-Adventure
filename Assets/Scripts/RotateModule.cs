using System;
using System.Collections.Generic;

using UnityEngine;

class RotateModule : MonoBehaviour
{
    //  1.      행성계 구현하기
    //  1++.    행성계 곡선으로 구현하기
    //  2.      isRotate 구현하기

    //  복학생용 숙제. 텍스처 입혀오기

    public float speed = 10;
    [SerializeField] private bool isRotate = true;

    private void Update()
    {
        transform.RotateAround(
            Vector3.zero,               //  회전할 대상의 포지션
            new Vector3(0, 1, 1),       //  회전할 대상 축
            speed);                     //  회전 속도
    }
    
}
