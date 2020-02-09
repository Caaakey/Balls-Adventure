using System;
using System.Collections.Generic;

using UnityEngine;

class RotateModule : MonoBehaviour
{
    public float speed = 10;
    [SerializeField] private bool isRotate = true;

    public Transform target = null;
    public Vector3 point = Vector3.zero;
    public Vector3 axis = Vector3.zero;

    private void Update()
    {
        if (isRotate == false) return;

        if (target != null)
        {
            //  타겟이 비어있지 않으면

            transform.RotateAround(target.localPosition, axis, speed);
            // 나는 해당 축으로 회전한다
            // target 의 localPosition 의 위치를 기준으로
            // axis 에 speed 값을 곱한 값으로 회전한다
        }
        else if (point != Vector3.zero)
        {
            transform.RotateAround(point, axis, speed);
        }
        else
        {
            transform.Rotate(axis, speed);
        }

    }
    
}
