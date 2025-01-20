using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani_Door : MonoBehaviour
{
    private Animator animator;
    public Vector3 doorOpenPosition;  // �J�����ʒu
    public Vector3 doorClosedPosition;  // �����ʒu

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animator.SetTrigger("Open");  // �A�j���[�V�������Đ�
        transform.position = doorOpenPosition;  // �h�A�̈ʒu���J�����ʒu�ɕύX
    }

    public void CloseDoor()
    {
        animator.SetTrigger("Close");  // �A�j���[�V�������Đ�
        transform.position = doorClosedPosition;  // �h�A�̈ʒu������ʒu�ɕύX

    }
}
