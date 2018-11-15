using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// name it whatever you want.
public class button : MonoBehaviour
{
  public Button m_YourFirstButton;
  void Start()
  {
     m_YourFirstButton.onClick.AddListener(TaskOnClick);
  }
  void TaskOnClick()
  {
   Debug.Log("Clik");
   SceneManager.LoadScene ("Intro"); 
   SceneManager.LoadScene ("Playables", LoadSceneMode.Additive);
  }
}
