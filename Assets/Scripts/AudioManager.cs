using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("----------------Audio Source----------------")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    [Header("----------------Audio Clip----------------")]
    public AudioClip background;
    public AudioClip battleTheme;

    private static AudioManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic(background);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "Battleground") // Assuming 0 is the main menu scene index
        {
            PlayMusic(battleTheme);
        }
        else if (scene.name == "MainMenu")
        {
            PlayMusic(background);
        }
    }

    private void PlayMusic(AudioClip clip)
    {
        if (musicSource.clip == clip)
        {
            return;
        }
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }

}
