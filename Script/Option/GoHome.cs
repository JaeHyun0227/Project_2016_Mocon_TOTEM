using UnityEngine;
using System.Collections;
public class GoHome : MonoBehaviour {

    public GameObject Option;
    public GameObject Check;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Option.SetActive(false);
            Check.SetActive(true);
        }
    }
}
