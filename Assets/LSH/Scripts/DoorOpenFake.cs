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

            // 소리재생 (잠금해제)
            Debug.Log("문1 잠금해제 사운드");

        }


    }

    public void DoorUnlockOpen()
    {

        if (isDoorOpenFake == false)
            return;
        else
        {
            //심플 그랩으로 문손잡이 잡았다 떼면
            Debug.Log("손잡이를 당겼다 놓자, \n문이 팍 하고 열렸다.");

            // 소리재생 (열리는 소리)
            Debug.Log("문1 팍 열리는 사운드");

            // 문 열리는 애니메이션 재생
            FakeDoorUnlock.SetTrigger("UnLockFake");

        }



    }

}
