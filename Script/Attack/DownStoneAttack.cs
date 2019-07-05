using UnityEngine;
using System.Collections;

public class DownStoneAttack : MonoBehaviour {

    public SPEEDUP SPEEDUP;
    public float speed;
    public float spawn;
    Vector3 Pos;
    // Use this for initialization

    void Start()
    {
        Pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = SPEEDUP.bulletspeed;
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y <= Pos.y - 2)
        {
            Destroy(this.gameObject);
        }
    }
}
