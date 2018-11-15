using UnityEngine;
using UnityEngine.SceneManagement;

public class openOptions : MonoBehaviour
{
  void Start()
  {
            SceneManager.LoadScene ("Options", LoadSceneMode.Additive);
          }
}
