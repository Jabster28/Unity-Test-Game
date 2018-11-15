using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class introexiter : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
  {
    SceneManager.LoadScene("Level 1", LoadSceneMode.Additive);
    SceneManager.UnloadSceneAsync ("Intro");
  }

}
