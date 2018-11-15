using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
  void Start()
  {
            SceneManager.LoadScene ("Intro", LoadSceneMode.Additive);
            SceneManager.LoadScene ("Playables", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync ("Start");
          }
}
