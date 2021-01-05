﻿using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("投進音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="寶石")
        {
            AddScore();
        }
    }

    private void AddScore()
    {
        score += 1;
        textScore.text = "寶石：" + score;
        aud.PlayOneShot(soundIn,Random.Range(0.5f,1f));
    }
}
