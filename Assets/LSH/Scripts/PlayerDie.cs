using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerDie : MonoBehaviour
{

    [SerializeField] SphereCollider leftCollider;
    [SerializeField] GameObject GameOverUIImage;


    private void Start()
    {
        leftCollider.enabled = true;
        GameOverUIImage.SetActive(true);
        GameOverUIImage.GetComponent<RectTransform>().position = new Vector3(0f, 0f, 27.5f);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.layer == 7)// 7.Spike
    //    {
    //        Debug.Log("콜리전 - 플레이어 사망");

    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)// 7.Spike
        {
            GameOverUIImage.GetComponent<Animator>().SetTrigger("GameOver"); 
            Debug.Log("트리거 - 플레이어 사망");
            StartCoroutine(GameStopRoutine());


        }

    }


    IEnumerator GameStopRoutine()
    {
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 0f;
    }







}



