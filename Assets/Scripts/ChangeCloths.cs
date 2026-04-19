using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCloths : MonoBehaviour
{
    public GameObject body; //BaseBody
    public GameObject cloth1; //Cloth1
    public GameObject cloth2; //Cloth2

    void Start()
    {

    }

    void Update()
    {

    }

    public void ChangeCloth1()
    {
        if (GameObject.Find("cloth2(Clone)") != null)
        {
            GameObject desCloth = GameObject.Find("cloth2(Clone)");
            Destroy(desCloth);
        }

        GameObject cloth = Instantiate(cloth1);
        cloth.transform.SetParent(body.transform);
        cloth.transform.Translate(0, 0, 0);
    }

    public void ChangeCloth2()
    {
        if (GameObject.Find("cloth1(Clone)") != null)
        {
            GameObject desCloth = GameObject.Find("cloth1(Clone)");
            Destroy(desCloth);
        }

        GameObject cloth = Instantiate(cloth2);
        cloth.transform.SetParent(body.transform);
        cloth.transform.Translate(0, 0, 0);
    }
}
