using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    public IObjectPool<GameObject> Pool { get; set; }

    public float speed = 5f;

    void Update()
    {

        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

}
