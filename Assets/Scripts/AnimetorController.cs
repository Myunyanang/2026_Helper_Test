using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetorController : MonoBehaviour
{
    Animator anim;
    public ChangeCloths chanClo;

    void Start()
    {
        anim = GetComponent<Animator>();

        chanClo.onChangeMotionEvent += PlayChangeAnimetion;
    }


    void Update()
    {

    }

    public void PlayChangeAnimetion()
    {
        anim.SetTrigger("isChangeCloth");
    }

    public void EndChange()
    {
        chanClo.leButton.SetActive(true);
        chanClo.riButton.SetActive(true);
    }
}
