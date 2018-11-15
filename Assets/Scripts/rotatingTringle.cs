using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class rotatingTringle : MonoBehaviour
{
  public static float cheese = 0f;
void Update()
  {

      transform.Rotate(0, 4, 0);
          /*
      if (cheese < -0.1f)
      {
        cheese = cheese + 0.1f;
      } else {
        cheese = cheese + 0.1f;
      }
      if (cheese >= 1)
      {
              cheese = cheese - 0.1f;
        transform.Translate(0, cheese, 0);
    } else {
          cheese = cheese + 0.1f;
      transform.Translate(0, (cheese * -1), 0);

    }
    */
  }
  void OnTriggerEnter(Collider other)
  {
    SceneManager.LoadScene("Level 1", LoadSceneMode.Additive);
    SceneManager.UnloadSceneAsync ("Intro");
  }

}
