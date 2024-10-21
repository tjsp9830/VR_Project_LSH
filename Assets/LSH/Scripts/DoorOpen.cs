using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] Animator DoorUnlock;
    [SerializeField] bool isDoorOpen;


    private void Awake()
    {
        DoorUnlock = GetComponent<Animator>();
    }

    private void Start()
    {
        isDoorOpen = false;
    }

    public void DoorUnlockOpen()
    {

        if (isDoorOpen == false )
        {
            Debug.Log("���� ������");
            isDoorOpen = true;
            // �Ҹ���� (�������)
            //���� �׷����� �������� ��Ҵ� ����
            DoorUnlock.SetTrigger("UnLock");
        }



    }



}
