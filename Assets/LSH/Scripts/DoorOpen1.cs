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

            // 소리재생 (잠금해제)
            Debug.Log("문1 잠금해제 사운드");

        }


    }

    public void DoorUnlockOpen()
    {

        if (isDoor1Open == false)
            return;
        else 
        {
            //심플 그랩으로 문손잡이 잡았다 떼면
            Debug.Log("손잡이를 당겼다 놓자, \n문이 팍 하고 열렸다.");

            // 소리재생 (열리는 소리)
            Debug.Log("문1 팍 열리는 사운드");

            // 문 열리는 애니메이션 재생
            DoorUnlock.SetTrigger("UnLock1"); 

        }



    }



}
