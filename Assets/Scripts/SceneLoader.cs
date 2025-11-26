using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    
    public GameObject MainMenuUI;
    public GameObject DeckBuilderUI;
    public GameObject ClanUI;
    public GameObject ShopUI;
    public GameObject SettingsUI;

    public void LoadBattleground(){
        SceneManager.LoadScene("Battleground");
    }

    public void OpenDeckBuilder(){
        MainMenuUI.SetActive(false);
        DeckBuilderUI.SetActive(true);
    }
    public void DeckBuilderConfirm(){
        DeckBuilderUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    public void OpenClan(){
        MainMenuUI.SetActive(false);
        ClanUI.SetActive(true);
    }
    public void ClanReturn(){
        ClanUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    public void OpenSettings(){
        MainMenuUI.SetActive(false);
        SettingsUI.SetActive(true);
    }
    public void SettingsReturn(){
        SettingsUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }

    public void OpenShop(){
        MainMenuUI.SetActive(false);
        ShopUI.SetActive(true);
    }
    public void ShopReturn(){
        ShopUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }
}
