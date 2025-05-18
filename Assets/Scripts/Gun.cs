using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos; // �Ѿ˹߻��� ��Ȯ�� ��ġ

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
            return;// ���� ������ �� �ؿ� ����� ���� �ȵ�
        //Instantiate(bullet); // �Ѿ� ����

        //Instantiate(bullet, firePos); //������Ʈ ���� -firePos ���ʿ� ��ġ

        //Instantiate(bullet, Vector3.one, Quaternion.identity); //������Ʈ ���� - Vector�� ��ġ. Quaternion�� ȸ����

        Rigidbody bulletObj = Instantiate(bullet, firePos.position, firePos.rotation);

        bulletObj.AddForce(firePos.forward * 100 , ForceMode.Impulse);//���� ���� ��� �ν����Ϳ� ����

        bulletCount--;

        RefreshBulletCountUI();
    }
    void RefreshBulletCountUI()
    {
        txtBulletCount.text = bulletCount.ToString();
    }


}
