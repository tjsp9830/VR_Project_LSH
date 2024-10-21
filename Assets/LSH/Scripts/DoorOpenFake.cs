using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFake : MonoBehaviour
{

    [SerializeField] Animator FakeDoorUnlock;
    [SerializeField] bool isDoorOpenFake;


    private void Awake()
    {
        FakeDoorUnlock = GetComponent<Animator>();
    }

    private void Start()
    {
        isDoorOpenFake = false;
    }

    public void DoorUnlockSound()
    {
        if (isDoorOpenFake == false)
        {
            isDoorOpenFake = true;

            // �Ҹ���� (�������)
            Debug.Log("������ ������� ����");

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
            Debug.Log("�������� ������ ����");

            // �� ������ �ִϸ��̼� ���
            FakeDoorUnlock.SetTrigger("UnLockFake");

        }



    }

}
