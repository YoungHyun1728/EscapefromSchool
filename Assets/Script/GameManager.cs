using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    public int GameRestartCount = 1;
    public Text RestartCount;
    public Text ClearText;

    public bool IsClear = false;

    public AudioSource BGMAudioSource;
    public AudioSource EffectAudioSource;

    public AudioClip BGM1;
    public AudioClip BGM2;
    public AudioClip BGM3;

    public AudioClip BallThrowSound;
    public AudioClip BookDropSound;
    public AudioClip[] CarHorn;
    public AudioClip[] ShoesFootSound;
    public AudioClip[] GameOverSound;
    public AudioClip BreakAndCrash;
    public AudioClip BreakGlass;


    private void Awake()
    {
        if (GM != null)
        {
            Destroy(gameObject);
            return;
        }
        GM = this;
        DontDestroyOnLoad(GM);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayeyDie()
    {
        GameRestartCount++;
        SetRestartText();
    }

    public void ClearWithText()
    {
        ClearText.gameObject.SetActive(true);
        ClearText.text = "Graduated with " + GameRestartCount + " Challenges!!";
        IsClear = true;
    }

    public void SetRestartText()
    {
        ClearText.gameObject.SetActive(false);
        RestartCount.text = GameRestartCount.ToString() + " Challenges";
    }
}
