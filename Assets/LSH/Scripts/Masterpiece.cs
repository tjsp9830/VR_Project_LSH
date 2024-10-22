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


    private void Start()
    {
        veiwSeconds = 0f;
        TriggerOff = false;
        TriggerObj.SetActive(true);
    }

    public void MasterPieceCome()
    {

        // 소리재생 (열리는 소리)
        Debug.Log("명화가 다가오는 사운드");

        // 문 열리는 애니메이션 재생
        masterPieceCome.SetTrigger("ComeOn");

        

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
            veiwSeconds += 0.1f;

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
