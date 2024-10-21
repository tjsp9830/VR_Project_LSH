using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class CupSocket : MonoBehaviour
{

    [SerializeField] GameObject CupArea;
    [SerializeField] GameObject CupPos;

    public UnityAction doorUnLock;

    
    public void CupPosIsSocketPos(SelectEnterEventArgs Args)
    {

        // ���� ���ͷ��ͺ� �̺�Ʈ�� ���� �ְ� ���� ���ϴ� �ֶ� �������� �Ǵ��ؾ��� 
        if (Args.interactableObject.transform == CupPos.transform) 
        {
            Debug.Log("Ʈ�Ѹ� �� �� ������ \n������ �̷��. ��1 ��� ����");
            doorUnLock?.Invoke();

        }


    }

}
