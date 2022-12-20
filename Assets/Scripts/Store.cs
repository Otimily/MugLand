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

        // 에러!!
        //만들어둔 함수와 인자값의 갯수가 다르다.
        //Func(1, 2); - X

        // 에러!!
        //만들어둔 함수와 인자값의 타입이 다르다.
        //Func(1, 2, "3"); - X

        // 정상 동작
        //만들어두 함수와 인자값의 수와 타입이 같다.
        //Func(1, 2, 3); - O

       

    }

    // 인자값, 파라미터, 변수저날
    void Func(int x, int y, int z) //이것은 규칙이다. 약속이다.
    {

    }


    public void BuyItem(ShopItem item)
    {
        
        if (myMoney - item.money >= 0)
        {
            //구매 성공
            myMoney = myMoney - item.money;

            txtMoney.text = myMoney + "Q";

            txtMoney.gameObject.SetActive(true);

            Debug.Log( item.name + "아이템을 구매해주셔서 감사합니다!");
        }

        else
        {
            //구매 실패
            txtMoney.gameObject.SetActive(false);

        }
    }
}
