using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("AudioSources")]
    [SerializeField] private AudioSource bgmSources;
    [SerializeField] private AudioSource sfxSources;

    [Header("BackgroundMusic")]

    [SerializeField] private AudioClip backgroundMusic;

    [Header("Sound Effect")]
    [SerializeField] private AudioClip pickupSound;
    [SerializeField] private AudioClip winningSound;
    [SerializeField] private AudioClip buttonClickSound;

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void Start()
    {
        PlayMusic();

    }

    private void PlayMusic()
    {
        if(backgroundMusic == null)
            return;
        bgmSources.clip = backgroundMusic;
        bgmSources.Play();
    }

    public void StopBackgroundMusic()
    {
        bgmSources.Stop();
    }
    
    public void PlayPickupSound()
    {
        if(pickupSound != null)
        {
            sfxSources.PlayOneShot(pickupSound);
        }
    }

    public void PlayWinningSound()
    {
        if(winningSound != null)
        {
            sfxSources.PlayOneShot(winningSound);
        }
    }

        public void PlayButtonClickSound()
    {
        if(buttonClickSound != null)
        {
            sfxSources.PlayOneShot(buttonClickSound);
        }
    }

}
