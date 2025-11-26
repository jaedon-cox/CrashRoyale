using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    
    public GameObject MainMenuUI;
    public GameObject DeckBuilderUI;
    public GameObject ClanUI;

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
}
