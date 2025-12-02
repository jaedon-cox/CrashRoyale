using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ShopManager : MonoBehaviour
{
    public int[,] shopItems = new int[6, 6]; // 1=row IDs, 2=price, 3=quantity
    public float coins;
    public TextMeshProUGUI coinsTXT;

    private void Start()
    {
        // Load saved coins if exists
        coins = PlayerPrefs.GetFloat("Coins", coins);
        coinsTXT.text = coins.ToString();

        // Initialize item IDs
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;

        // Initialize prices
        shopItems[2, 1] = 10000;
        shopItems[2, 2] = 500;
        shopItems[2, 3] = 100;
        shopItems[2, 4] = 100;
        shopItems[2, 5] = 100;

        // Load purchased quantities
        for (int i = 1; i <= 5; i++)
        {
            shopItems[3, i] = PlayerPrefs.GetInt("ItemQuantity_" + i, 0);
            // Optional: update UI text here if needed
            // ButtonInfo for quantity display
        }
    }

    public void Buy()
    {
        // Get the clicked button
        GameObject buttonRef = EventSystem.current.currentSelectedGameObject;
        if (buttonRef == null) return;

        ButtonInfo info = buttonRef.GetComponent<ButtonInfo>();
        int itemId = info.itemId;

        // Check if enough coins
        if (coins >= shopItems[2, itemId])
        {
            // Deduct coins
            coins -= shopItems[2, itemId];
            coinsTXT.text = coins.ToString();
            PlayerPrefs.SetFloat("Coins", coins);

            // Increase quantity
            shopItems[3, itemId]++;
            PlayerPrefs.SetInt("ItemQuantity_" + itemId, shopItems[3, itemId]);

            PlayerPrefs.Save();

            // Optional: update quantity UI
            // info.quantityTxt.text = shopItems[3, itemId].ToString();

            Debug.Log("Purchased item " + itemId + ". Total: " + shopItems[3, itemId]);
        }
        else
        {
            Debug.Log("Not enough coins for item " + itemId);
        }
    }
}
