using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class PlayerDie : MonoBehaviour
{

    [SerializeField] SphereCollider leftCollider;
    [SerializeField] GameObject GameOverUIImage;
    [SerializeField] DynamicMoveProvider moveScript;
    [SerializeField] GameObject LeftController;
    [SerializeField] GameObject RightController;


    private void Start()
    {
        leftCollider.enabled = true;
        GameOverUIImage.SetActive(false);
        moveScript.moveSpeed = 3f;
        LeftController.SetActive(true);
        RightController.SetActive(true);
        //GameOverUIImage.GetComponent<RectTransform>().position = new Vector3(0f, 0f, 27.5f);
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
            //GameOverUIImage.GetComponent<Animator>().SetTrigger("GameOver"); 
            Debug.Log("트리거 - 플레이어 사망");
            GameOverUIImage.SetActive(true);
            moveScript.moveSpeed = 0f;
            

            StartCoroutine(GameStopRoutine());

        }

    }


    IEnumerator GameStopRoutine()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1f);
        LeftController.SetActive(false);
        RightController.SetActive(false);
    }







}



