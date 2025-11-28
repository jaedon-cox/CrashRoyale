using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ButtonInfo : MonoBehaviour
{
    public int itemId;
    public TextMeshProUGUI priceTxt;
    public TextMeshProUGUI quantityTxt;
    public GameObject shopManager;

    // Update is called once per frame
    void Update()
    {
        priceTxt.text = shopManager.GetComponent<ShopManager>().shopItems[2, itemId].ToString();
        //priceTxt.text = shopManager.GetComponent<ShopManager>().shopItems[3, itemId].ToString();
    }
}
