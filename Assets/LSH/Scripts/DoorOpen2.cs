using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen2 : MonoBehaviour
{

    [SerializeField] Animator DoorUnlock2;
    [SerializeField] bool isDoor2Open;
    [SerializeField] Masterpiece Door2Event;

    private void Awake()
    {
        DoorUnlock2 = GetComponent<Animator>();
    }

    private void Start()
    {
        Door2Event.TimesUp += Door2UnlockSound;
        isDoor2Open = false;
    }

    public void Door2UnlockSound()
    {
        if (isDoor2Open == false)
        {
            isDoor2Open = true;

            // 소리재생 (잠금해제)
            Debug.Log("문2 잠금해제 사운드");

        }


    }

    public void Door2UnlockOpen()
    {

        if (isDoor2Open == false)
            return;
        else
        {
            //심플 그랩으로 문손잡이 잡았다 떼면
            Debug.Log("손잡이를 당겼다 놓자, \n문이 팍 하고 열렸다.");

            // 소리재생 (열리는 소리)
            Debug.Log("문2 팍 열리는 사운드");

            // 문 열리는 애니메이션 재생
            DoorUnlock2.SetTrigger("UnLock2");

        }



    }



}
