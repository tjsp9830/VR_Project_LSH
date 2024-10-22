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
    [SerializeField] AudioClip SFX_JumpSquareAfter;


    private void Start()
    {
        veiwSeconds = 0f;
        TriggerOff = false;
        TriggerObj.SetActive(true);
    }

    public void MasterPieceCome()
    {
        if(TriggerOff==false)
            StartCoroutine(JumpSquartSound(2f));
        

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
            TriggerOff = true;
            TriggerObj.SetActive(false);
        }

        Debug.Log("보기 끝");
        StopCoroutine(viewMasterPiece);
    }


    IEnumerator JumpSquartSound(float delay)
    {
        yield return new WaitForSeconds(delay);

        // 그림이 다가오는 애니메이션
        masterPieceCome.SetTrigger("ComeOn");

        // 그림이 다가오면서 놀라게끔 나오는 사운드
        SoundManager.Instance.PlayOtherSFX(SFX_JumpSquare);

        yield return new WaitForSeconds(3f);

        // 진짜 놀랜 플레이어의 숨고르기 사운드
        SoundManager.Instance.PlayMySFX(SFX_JumpSquareAfter);

        yield return new WaitForSeconds(3f);

        // 그만 쉬기
        SoundManager.Instance.StopMySFX();

    }


    public IEnumerator ViewMasterPiece()
    {
        yield return new WaitForSeconds(3f);

        while (true)
        {
            veiwSeconds += 0.1f;

            yield return 0.1f;

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
