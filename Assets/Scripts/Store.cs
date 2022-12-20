using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Store : MonoBehaviour
{
    int myMoney = 5000;
    public Text txtMoney;

    void Start()
    {
        txtMoney.text = myMoney + "Q";

        // ����!!
        //������ �Լ��� ���ڰ��� ������ �ٸ���.
        //Func(1, 2); - X

        // ����!!
        //������ �Լ��� ���ڰ��� Ÿ���� �ٸ���.
        //Func(1, 2, "3"); - X

        // ���� ����
        //������ �Լ��� ���ڰ��� ���� Ÿ���� ����.
        //Func(1, 2, 3); - O

       

    }

    // ���ڰ�, �Ķ����, ��������
    void Func(int x, int y, int z) //�̰��� ��Ģ�̴�. ����̴�.
    {

    }


    public void BuyItem(ShopItem item)
    {
        
        if (myMoney - item.money >= 0)
        {
            //���� ����
            myMoney = myMoney - item.money;

            txtMoney.text = myMoney + "Q";

            txtMoney.gameObject.SetActive(true);

            Debug.Log( item.name + "�������� �������ּż� �����մϴ�!");
        }

        else
        {
            //���� ����
            txtMoney.gameObject.SetActive(false);

        }
    }
}
