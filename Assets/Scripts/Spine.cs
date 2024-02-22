using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spine : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            GameManager.instance.GameOver();
        }
    }


}
