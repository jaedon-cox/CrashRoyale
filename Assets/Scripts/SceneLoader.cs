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
        SceneManager.LoadScene("Deck");
    }
    public void DeckBuilderConfirm(){
        DeckBuilderUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }
    public void DeckReturn()
    {
        SceneManager.LoadScene("MainMenu");
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
        SceneManager.LoadScene("Shop");
    }
    public void ShopReturn(){
        SceneManager.LoadScene("MainMenu");
    }
}

