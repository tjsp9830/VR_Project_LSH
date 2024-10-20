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
            Debug.Log("문이 열린다");
            isDoorOpen = true;
            //소리재생
            //문이 팍!!!!!! 열리는 애니메이션 재생
            Door.GetComponent<Animator>().SetTrigger("UnLock");
        }



    }



}
