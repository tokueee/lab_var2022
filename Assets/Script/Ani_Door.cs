using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani_Door : MonoBehaviour
{
    private Animator animator;
    public Vector3 doorOpenPosition;  // 開いた位置
    public Vector3 doorClosedPosition;  // 閉じた位置

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animator.SetTrigger("Open");  // アニメーションを再生
        transform.position = doorOpenPosition;  // ドアの位置を開いた位置に変更
    }

    public void CloseDoor()
    {
        animator.SetTrigger("Close");  // アニメーションを再生
        transform.position = doorClosedPosition;  // ドアの位置を閉じた位置に変更

    }
}
