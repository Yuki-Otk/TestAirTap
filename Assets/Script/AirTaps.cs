using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class AirTaps : MonoBehaviour, IFocusable, IInputClickHandler
{
    public Material blue, green,red;

    public void OnFocusEnter()//gazeに入ったら
    {
        GetComponent<Renderer>().material = blue;//blueをアタッチ
    }

    public void OnFocusExit()//gazeから出たら
    {
        GetComponent<Renderer>().material = green;//アタッチ
    }

    public void OnInputClicked(InputClickedEventData eventData)//エアタップされたら
    {
        //GetComponent<Renderer>().material = red;//色を変更
        Color rand = new Color(Random.value, Random.value, Random.value, 1.0f);//ランダムで色を生成
        GetComponent<Renderer>().material.color = rand;//アタッチ
        transform.Rotate(new Vector3(0, 15, 0));
    }
}