using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text.RegularExpressions;

public class ManageMenus : MonoBehaviour {
    
    public GameObject LoginUI;
    public GameObject RegisterUI;

    private Regex emailPattern = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

    public TMP_InputField registerEmailInput;
    public TMP_InputField registerPasswordInput;
    public TMP_InputField registerPasswordConfirm;

    public TMP_InputField loginEmail;
    public TMP_InputField loginPassword;

    public void OpenRegister(){
        LoginUI.SetActive(false);
        RegisterUI.SetActive(true);
    }
    public void CancelRegister(){
        RegisterUI.SetActive(false);
        LoginUI.SetActive(true);
    }

    public void registerAccount(){
        string email = registerEmailInput.text;
        string pass = registerPasswordInput.text;
        string passConfirm = registerPasswordConfirm.text;

        if(!emailPattern.IsMatch(email)){
            return;
        }
        if(pass != passConfirm || pass.Length < 4){
            return;
        }

        SceneManager.LoadScene("MainMenu");
    }

    public void loginAccount(){
        string email = loginEmail.text;
        string pass = loginPassword.text;

        if(!emailPattern.IsMatch(email)){
            return;
        }
        if(pass.Length < 4){
            return;
        }

        SceneManager.LoadScene("MainMenu");
    }
}


