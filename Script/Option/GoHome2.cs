using UnityEngine;
using System.Collections;

public class GoHome2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
        }
    }
}
