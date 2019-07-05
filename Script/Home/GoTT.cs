using UnityEngine;
using System.Collections;

public class GoTT : MonoBehaviour {

    public Sprite S1, S2;
	// Use this for initialization
	void Start () {
        	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = S1;
            yield return new WaitForSeconds(0.2f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;
            UnityEngine.SceneManagement.SceneManager.LoadScene("TT");
        }
    }
}
