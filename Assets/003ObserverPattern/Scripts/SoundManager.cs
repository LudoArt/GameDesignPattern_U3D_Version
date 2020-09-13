using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    private SMObserver m_sMObserver;

    /// <summary>
    /// 游戏的背景音乐
    /// </summary>
    public AudioClip _BGM;
    /// <summary>
    /// 游戏在出现标题的时候播放的音乐
    /// </summary>
    public AudioClip _titleBGM;

    /// <summary>
    /// 是否打开了标题
    /// </summary>
    public bool isOpenTitle = false;

    private void Start()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        if (m_sMObserver == null)
            m_sMObserver = new SMObserver();
        Subject.Instance.AddObserver(m_sMObserver);
    }

    public void PlayBGM()
    {
        audioSource.Stop();
        audioSource.clip = _BGM;
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void PlayTitleBGM()
    {
        audioSource.Stop();
        audioSource.clip = _titleBGM;
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
