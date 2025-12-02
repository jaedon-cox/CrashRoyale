using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageMenus : MonoBehaviour {
    
    public GameObject LoginUI;
    public GameObject RegisterUI;

    public void OpenRegister(){
        LoginUI.SetActive(false);
        RegisterUI.SetActive(true);
    }
    public void CancelRegister(){
        RegisterUI.SetActive(false);
        LoginUI.SetActive(true);
    }
}


