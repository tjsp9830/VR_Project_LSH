using UnityEngine;

public class DoorOpenFake : MonoBehaviour
{

    [SerializeField] Animator FakeDoorUnlock;
    //[SerializeField] bool isDoorOpenFake;


    private void Awake()
    {
        FakeDoorUnlock = GetComponent<Animator>();
    }


    public void DoorUnlockSound()
    {
        // 소리재생 (잠금해제)
        Debug.Log("함정문 잠금해제 사운드");


    }

    public void DoorUnlockOpen()
    {

        //심플 그랩으로 문손잡이 잡았다 떼면
        Debug.Log("손잡이를 당겼다 놓자, \n문이 팍 하고 열렸다.");

        // 소리재생 (열리는 소리)
        Debug.Log("함정문이 열리는 사운드");

        // 문 열리는 애니메이션 재생
        FakeDoorUnlock.SetTrigger("UnLockFake");



    }

}
