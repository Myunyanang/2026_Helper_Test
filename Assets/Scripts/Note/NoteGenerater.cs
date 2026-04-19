using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NoteGenerater : MonoBehaviour
{
    public GameObject note1;
    public GameObject canvars;
    private double time = 0f;
    double bpm = 140f;

    void Start()
    {

    }

    void Update()
    {
        time += Time.deltaTime; //1초가 되었을 때 1이 되도록
        if (time >= 60d / bpm) //한 박자당 초
        {
            int randomNum = UnityEngine.Random.Range(1, 5); //1 이상 5 미만 정수
            addNote(randomNum);
            time -= 60d / bpm;
        }
    }

    void addNote(int noteNum)
    {
        Debug.Log("테스트 1");
        GameObject note = Instantiate(note1);
        RectTransform pos;
        if (noteNum == 1)
        {
            note.transform.SetParent(canvars.transform);
            pos = note.GetComponent<RectTransform>();
            pos.anchoredPosition = new Vector2(260, 940); //좌표같은 경우에는 왼쪽 밑이 0, 0이고 오른쪽 위가 1980, 1080으로 됨.
        }
        else if (noteNum == 2)
        {
            note.transform.SetParent(canvars.transform);
            pos = note.GetComponent<RectTransform>();
            pos.anchoredPosition = new Vector2(560, 840);
        }
        else if (noteNum == 3)
        {
            note.transform.SetParent(canvars.transform);
            pos = note.GetComponent<RectTransform>();
            pos.anchoredPosition = new Vector2(1360, 840);
        }
        else if (noteNum == 4)
        {
            note.transform.SetParent(canvars.transform);
            pos = note.GetComponent<RectTransform>();
            pos.anchoredPosition = new Vector2(1660, 940);
        }
    }
}
