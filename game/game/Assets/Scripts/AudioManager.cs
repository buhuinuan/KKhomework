using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //为了可以在多个地方使用，先给自己赋一个静态的值
    public static AudioManager Instance;
    public AudioClip Hip;
    public AudioClip Bomb;
    public AudioClip Coin;
    public AudioClip Win;
    //声明AudioSource组件
    private AudioSource player;
    void Awake()
    {
        Instance = this;
        player = GetComponent<AudioSource>();
    }
    public void PlayHip()
    {
        player.PlayOneShot(Hip);
    }
    public void PlayBomb()
    {
        player.PlayOneShot(Bomb);
    }
    public void PlayCoin()
    {
        player.PlayOneShot(Coin);
    }
    public void PlayWin()
    {
        player.PlayOneShot(Win);
    }
}
