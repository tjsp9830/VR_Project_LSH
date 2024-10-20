using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] GameObject Door;
    [SerializeField] bool isDoorOpen;


    private void Start()
    {
        isDoorOpen = false;
    }

    private void Update()
    {

        if (isDoorOpen == false && Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("���� ������");
            isDoorOpen = true;
            //�Ҹ����
            //���� ��!!!!!! ������ �ִϸ��̼� ���
            Door.GetComponent<Animator>().SetTrigger("UnLock");
        }



    }



}
