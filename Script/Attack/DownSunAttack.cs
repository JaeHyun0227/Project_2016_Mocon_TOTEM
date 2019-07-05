using UnityEngine;
using System.Collections;

public class DownSunAttack : MonoBehaviour {

    public SPEEDUP SPEEDUP;
    public float speed;
    public float spawn;
    public int stack = 0;
    Vector3 Pos;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            stack++;
        }
    }
    void Start()
    {
        Pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = SPEEDUP.bulletspeed;
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y <= Pos.y - 5.5 || stack >= 3)
        {
            Destroy(this.gameObject);
        }
    }
}

