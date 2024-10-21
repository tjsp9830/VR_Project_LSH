using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFake : MonoBehaviour
{

    [SerializeField] Animator FakeDoorUnlock;
    [SerializeField] bool isDoorOpenFake;

    [SerializeField] CupSocket cupSocket;

    private void Awake()
    {
        FakeDoorUnlock = GetComponent<Animator>();
    }

    private void Start()
    {
        cupSocket.doorUnLock += DoorUnlockSound;
        isDoorOpenFake = false;
    }

    public void DoorUnlockSound()
    {
        if (isDoorOpenFake == false)
        {
            isDoorOpenFake = true;

            // �Ҹ���� (�������)
            Debug.Log("��1 ������� ����");

        }


    }

    public void DoorUnlockOpen()
    {

        if (isDoorOpenFake == false)
            return;
        else
        {
            //���� �׷����� �������� ��Ҵ� ����
            Debug.Log("�����̸� ���� ����, \n���� �� �ϰ� ���ȴ�.");

            // �Ҹ���� (������ �Ҹ�)
            Debug.Log("��1 �� ������ ����");

            // �� ������ �ִϸ��̼� ���
            FakeDoorUnlock.SetTrigger("UnLockFake");

        }



    }

}
