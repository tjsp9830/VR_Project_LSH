using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class CupSocket : MonoBehaviour
{

    [SerializeField] GameObject CupArea;
    [SerializeField] GameObject CupPos;

    public UnityAction door1UnLock;

    
    public void CupPosIsSocketPos(SelectEnterEventArgs Args)
    {

        // 꽂힌 인터렉터블 이벤트에 들어온 애가 내가 원하는 애랑 같은지를 판단해야함 
        if (Args.interactableObject.transform == CupPos.transform) 
        {
            Debug.Log("트롤리 위 컵 갯수가 \n균형을 이뤘다. 문1 잠금 해제");
            door1UnLock?.Invoke();

        }


    }

}
