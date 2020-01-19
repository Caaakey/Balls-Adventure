using System.Collections;
using System.Collections.Generic;

using UnityEngine;

//  컴포넌트화 시키려면 반드시 MonoBehaviour 를 상속받아야함
public class CubeRotateModule : MonoBehaviour
{
    //  기본 접근자
    //  접근 가능?
    //  public      private     protected
    //  O           X           X
    //  상속 접근 가능?
    //  O           X           O

    //  처음 실행되고 다시는 실행되지 않는 함수
    //  최초 1회 실행되는 함수
    private void Awake()
    {
        Debug.Log("Hello World!");

        //  기본으로 제공하는 정보들
        Debug.Log(name);
        //  transform   -   해당 오브젝트의 위치 정보를 담고 있는 컴포넌트
        //  gameObject  -   해당 오브젝트 자기 자신 (tag, layer 등등 정보를 담고 있음)

        //  world 좌표, local 좌표
        //  world 좌표는 transform.position, rotation, lossyScale
        //transform.position = new Vector3(1, 0, 0);
        //transform.Translate(1, 0, 0);

        //  local 좌표는 transform.local (접두가 붙는다)

        int money = 10000;

    }

    //  업데이트 들어갈 때 마다 angle 값은 0.5f 씩 증가하고
    //  해당 angle 값을 transform.localRotation Z 축에 넣어보세요!
    float angle = 0;

    //  계속 실행되는 함수
    private void Update()
    {
        //  Input.GetKey - 눌러져 있다면 true 를 반환한다
        //  Input.GetKeyDown - 눌렀을 때 true 를 반환한다
        //  Input.GetKeyUp - 눌렀다 뗏을 때 true 를 반환한다

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.Translate(-0.1f, 0, 0);
            transform.localPosition = new Vector3(-0.1f, 0, 0);
        }

        //angle += 0.5f;
        //transform.localRotation = Quaternion.Euler(0, 0, angle);
    }

    //  Ctrl + Shift + B 전체 빌드 단축키
}
