using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// name it whatever you want.
public class PlayerController : MonoBehaviour
{
  SpriteRenderer m_SpriteRenderer;
  void Start()
  {
    m_SpriteRenderer = GetComponent<SpriteRenderer>();
  }
    void Update()
    {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 15.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 15.0f;

        transform.Translate(x, 0, 0);
        
				if (y > (-1.94))
				{
				transform.Translate(0, y, 0);
			}
      if (transform.position.y < -15)
      {
        Debug.Log(2);
  transform.position = new Vector2(0, 0);
      }
      if (Input.GetKeyDown("a"))
      {
      if (m_SpriteRenderer.flipX == false)
      {
        m_SpriteRenderer.flipX = true;
      }
    }
    if (Input.GetKeyDown("d"))
    {
      if (m_SpriteRenderer.flipX == true)
      {
m_SpriteRenderer.flipX = false;
    }
  }

}
}
