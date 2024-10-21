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
            Debug.Log("문이 열린다");
            isDoorOpen = true;
            // 소리재생 (잠금해제)
            //심플 그랩으로 문손잡이 잡았다 떼면
            DoorUnlock.SetTrigger("UnLock");
        }



    }



}
