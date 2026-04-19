using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class NoteController : MonoBehaviour
{
    //bool isNoteCheck = false; //노트판정을 체크했는지
    public double realTime;
    public double inputTime;
    public double noteTime14 = 1.0f;
    public double noteTime23 = 1.0417f;
    public float speed = 8f;
    public GameObject noteLine; //노트 라인 오브젝트 저장용 변수
    public int noteLineNumber = 1; // 몇번 노트 라인으로 내려가는 노트인가
    public int checkNoteLineNum = 0; //입력받은 노트라인 체크

    void Start()
    {
        RectTransform notePos;
        notePos = this.gameObject.GetComponent<RectTransform>();

        if (notePos.anchoredPosition.x == 260)
        {
            noteLineNumber = 1;
        }
        else if (notePos.anchoredPosition.x == 560)
        {
            noteLineNumber = 2;
        }
        else if (notePos.anchoredPosition.x == 1360)
        {
            noteLineNumber = 3;
        }
        else if (notePos.anchoredPosition.x == 1660)
        {
            noteLineNumber = 4;
        }

        this.noteLine = GameObject.Find("NoteLine" + noteLineNumber);
    }

    void Update()
    {
        //프레임마다 스피드만큼 낙하시킨다. 프레임 고정시켜서 추가 코드 없음. 변경시 추가 필요.
        transform.Translate(0, -speed, 0);
        this.realTime += Time.deltaTime;
    }

    /*
        void InputStop()
        {
            if (checkNoteLineNum == noteLineNumber)
            {
                if (noteLineNumber == 1 || noteLineNumber == 4)
                {
                    if (realTime >= 0.9 || realTime <= 1.1)
                    {
                        NoteCheck();
                    }
                }
                else if (noteLineNumber == 2 || noteLineNumber == 3)
                {
                    if (realTime >= 0.9417 || realTime <= 1.1417)
                    {
                        NoteCheck();
                    }
                }
            }
        }

        void NoteCheck()
        {
            if (isNoteCheck == false)
            {
                inputTime = realTime;
                isNoteCheck = true;
                //판정진행
            }
        }
        */

    //노트 판정 방식 (1번으로 우선구현)
    //1. 노트 생성 시간 기반
    //2. 노트와 판정선까지의 거리 기반

    //특정 초 사이에 해당 라인의 버튼 눌림 신호가 온다면 리얼타임 저장하고 판정. 이 방식 괜찮으려나? 

}
