﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource sfxSource;
    public AudioClip sfxSelect;

    // Responsável por abrir a scene com o nome que estiver configurado
    public IEnumerator Delay(string nameScene)
    {
        sfxSource.PlayOneShot(sfxSelect, 1f);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(nameScene);
    }

    public void OpenScene(string nameScene)
    {
        StartCoroutine("Delay", nameScene);
    }
}
