using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class SPEEDUP : MonoBehaviour {

    public bool SPEED = false;
    public float speed = 1;
    public float spawnTime = 1;
    public float bulletspeed = 1;
    public float bulletspawn = 100;
    public float AttackTime = 80;
    public Sprite S,S2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && SPEED == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
            speed *= 2f;
            spawnTime /= 2f;
            bulletspawn /= 2f;
            AttackTime /= 2f;
            bulletspeed *= 2f;
            SPEED = true;
            
        }
        else if (Input.GetMouseButtonDown(0) && SPEED == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;
            spawnTime *= 2f;
            bulletspawn *= 2f;
            AttackTime *= 2f;
            speed /= 2f;
            bulletspeed /= 2f;
            SPEED = false;
            
        }
    }
        
}