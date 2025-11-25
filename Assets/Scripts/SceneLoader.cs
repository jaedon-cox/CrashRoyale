using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    
    public void LoadBattleground(){
        SceneManager.LoadScene("Battleground");
    }
}
