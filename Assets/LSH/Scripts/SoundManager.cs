using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //씬이 하나이지만, BGM을 단독 사용하고 싶고 어디서든 가져올수 있기를 원하기 때문에 싱글톤으로 구현함

    public static SoundManager Instance { get; private set; }

    [SerializeField] AudioSource BGM;
    [SerializeField] AudioSource SFX_Me;
    [SerializeField] AudioSource SFX_Other;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        //else
        //{
        //    Destroy(gameObject);
        //}

    }


    public void PlayBGM(AudioClip clip)
    {

        BGM.clip = clip;
        BGM.Play();

    }

    //public void StopBGM()
    //{
    //    if (BGM.isPlaying == false)
    //        return;        

    //    BGM.Stop();

    //}

    public void ChangeBGM(AudioClip _clip)
    {
        BGM.Stop();
        BGM.clip = _clip;
        BGM.Play();

    }

    public void SetBGM(float volume, float pitch)
    {
        BGM.volume = volume;
        BGM.pitch = pitch;
    }



    public void PlayOtherSFX(AudioClip clip)
    {
        SFX_Other.clip = clip;
        SFX_Other.Play();
    }

    public void SetOtherSFX(float volume, float pitch)
    {
        SFX_Other.volume = volume;
        SFX_Other.pitch = pitch;
    }




}
