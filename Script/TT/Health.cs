using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class Health : MonoBehaviour {

    public int HP=100;
    public Sprite[] S = new Sprite[20];
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = S[HP/5];
        if (HP <= 0)
        {
        }
	}
    void Aoch()
    {
        
    }
}
