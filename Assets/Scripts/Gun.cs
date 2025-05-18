using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos; // 총알발사의 정확한 위치

    public TMP_Text txtBulletCount;

    // Start is called before the first frame update
    void Start()
    {
        RefreshBulletCountUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {

        if (bulletCount <= 0)
            return;// 조건 부적합 시 밑에 문장들 실행 안됨
        //Instantiate(bullet); // 총알 생성

        //Instantiate(bullet, firePos); //오브젝트 생성 -firePos 안쪽에 위치

        //Instantiate(bullet, Vector3.one, Quaternion.identity); //오브젝트 생성 - Vector의 위치. Quaternion의 회전값

        Rigidbody bulletObj = Instantiate(bullet, firePos.position, firePos.rotation);

        bulletObj.AddForce(firePos.forward * 100 , ForceMode.Impulse);//숫자 세개 사용 인스펙터에 노출

        bulletCount--;

        RefreshBulletCountUI();
    }
    void RefreshBulletCountUI()
    {
        txtBulletCount.text = bulletCount.ToString();
    }


}
