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
        GameOverUIImage.SetActive(false);
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
            Debug.Log("트리거 - 플레이어 사망");
            Time.timeScale = 0f;
            GameOverUIImage.SetActive(true);
        }

    }


}
