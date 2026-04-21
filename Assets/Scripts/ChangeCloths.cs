using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeCloths : MonoBehaviour
{
    public GameObject body; //BaseBody
    public GameObject[] cloths; //Cloths

    AnimetorController aniCon;
    int clothIndex = 0;

    public Action onChangeMotionEvent;


    void Start()
    {
        ChangeCloth();
        aniCon = body.GetComponent<AnimetorController>();

        aniCon.onChangeCloth += ChangeCloth;
    }

    void Update()
    {

    }

    public void ChangeCloth()
    {
        GameObject desCloth = GameObject.FindWithTag("cloth");
        if (desCloth != null)
        {
            Destroy(desCloth);
        }

        GameObject cloth = Instantiate(cloths[clothIndex]);
        cloth.transform.SetParent(body.transform);
        cloth.transform.Translate(0, 0, 0);
    }

    public void ClickLeftButton()
    {
        clothIndex -= 1;

        if (clothIndex == -1)
        {
            clothIndex = cloths.Length - 1;
        }
        onChangeMotionEvent.Invoke();
    }

    public void ClickRightButton()
    {
        clothIndex += 1;

        if (clothIndex == cloths.Length)
        {
            clothIndex = 0;
        }
        onChangeMotionEvent.Invoke();
    }
}
