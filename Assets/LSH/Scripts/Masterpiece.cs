using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Masterpiece : MonoBehaviour
{
    [SerializeField] Animator masterPieceCome;
    [SerializeField] GameObject TriggerObj;
    bool TriggerOff;
    Coroutine viewMasterPiece;
    [SerializeField] private float veiwSeconds;
    public UnityAction TimesUp;

    [SerializeField] AudioClip SFX_JumpSquare;

    private void Start()
    {
        veiwSeconds = 0f;
        TriggerOff = false;
        TriggerObj.SetActive(true);
    }

    public void MasterPieceCome()
    {

        // 그림이 다가오는 애니메이션
        masterPieceCome.SetTrigger("ComeOn");

        // 그림이 다가오니까 놀래줬으면 하는 사운드        
        SoundManager.Instance.SetOtherSFX(100f, 2f);
        SoundManager.Instance.PlayOtherSFX(SFX_JumpSquare);

        

    }


    public void ViewStart()
    {
        Debug.Log("보기 시작");
        viewMasterPiece = StartCoroutine(ViewMasterPiece());
    }

    public void ViewEnd()
    {
        if (TriggerOff == false)
        {
            Debug.Log("트리거 물체 사라짐");
            TriggerOff = true;
            TriggerObj.SetActive(false);
        }

        Debug.Log("보기 끝");
        StopCoroutine(viewMasterPiece);
    }




    public IEnumerator ViewMasterPiece()
    {
        while (true)
        {
            veiwSeconds += 0.05f;

            if (veiwSeconds >= 100f)
            {
                Debug.Log("명화를 뚫어져라 쳐다보자, 문이 열리는 소리가 들렸다.");
                break;
            }
            
        }

        yield return null;
        TimesUp?.Invoke();

    }


}
