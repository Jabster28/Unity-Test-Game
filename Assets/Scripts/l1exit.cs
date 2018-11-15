using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class l1exit : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
  {
    SceneManager.LoadScene("Level 2", LoadSceneMode.Additive);
    SceneManager.UnloadSceneAsync ("Level 1");
  }

}
