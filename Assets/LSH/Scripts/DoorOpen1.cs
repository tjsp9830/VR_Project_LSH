using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen1 : MonoBehaviour
{

    [SerializeField] Animator DoorUnlock;
    [SerializeField] bool isDoor1Open;

    [SerializeField] CupSocket cupSocket;

    private void Awake()
    {
        DoorUnlock = GetComponent<Animator>();
    }

    private void Start()
    {
        cupSocket.door1UnLock += Door1UnlockSound;
        isDoor1Open = false;
    }

    public void Door1UnlockSound()
    {
        if (isDoor1Open == false)
        {
            isDoor1Open = true;

            // �Ҹ���� (�������)
            Debug.Log("��1 ������� ����");

        }


    }

    public void DoorUnlockOpen()
    {

        if (isDoor1Open == false)
            return;
        else 
        {
            //���� �׷����� �������� ��Ҵ� ����
            Debug.Log("�����̸� ���� ����, \n���� �� �ϰ� ���ȴ�.");

            // �Ҹ���� (������ �Ҹ�)
            Debug.Log("��1 �� ������ ����");

            // �� ������ �ִϸ��̼� ���
            DoorUnlock.SetTrigger("UnLock1"); 

        }



    }



}
