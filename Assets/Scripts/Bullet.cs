using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ������Ʈ �޷��ִ� ������Ʈ �ı� (Destroy(gameObject, �ı��� �ð�)
        Destroy(gameObject, 5);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
