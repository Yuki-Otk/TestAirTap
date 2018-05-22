using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour, IInputClickHandler
{
    private Animator animator;//Animatorを入れる変数
    private AnimatorStateInfo currentState, previousState;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();//UnityちゃんのAnimatorにアクセスする
        currentState = animator.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
    }
	
	// Update is called once per frame
	void Update () {
        // "Next"フラグがtrueの時の処理
        if (animator.GetBool("Next"))
        {
            // 現在のステートをチェックし、ステート名が違っていたらブーリアンをfalseに戻す
            currentState = animator.GetCurrentAnimatorStateInfo(0);
            if (previousState.nameHash != currentState.nameHash)
            {
                animator.SetBool("Next", false);
                previousState = currentState;
            }
        }
    }
    public void OnInputClicked(InputClickedEventData eventData)//タップされたら
    {
        Debug.Log("in!!");
        animator.SetBool("Next", true);//アニメーション

    }
}
