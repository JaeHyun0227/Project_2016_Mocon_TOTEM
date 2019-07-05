using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
public class OptionOpen : MonoBehaviour {

    public GameObject Option;
    public Sprite S;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
            Option.SetActive(true);

        }
    }
}
