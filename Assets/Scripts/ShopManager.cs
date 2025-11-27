using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class ShopManager : MonoBehaviour
{
    public int[,] shopItems = new int[6, 6];
    public float coins;
    public TextMeshProUGUI coinsTXT;
    void Start()
    {
        coinsTXT.text = coins.ToString();

        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;

        //Price
        shopItems[2, 1] = 10000;
        shopItems[2, 2] = 500;
        shopItems[2, 3] = 100;
        shopItems[2, 4] = 100;
        shopItems[2, 5] = 100;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;



    }

    // Update is called once per frame
    public void Buy()
    {
        GameObject buttonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= shopItems[2, buttonRef.GetComponent<ButtonInfo>().itemId])
        {
            coins -= shopItems[2, buttonRef.GetComponent<ButtonInfo>().itemId];
            shopItems[3, buttonRef.GetComponent<ButtonInfo>().itemId]++;
            coinsTXT.text = coins.ToString();
            //ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = shopItems[3, buttonRef.GetComponent<ButtonInfo>().itemId].ToString();
        }

    }
}
