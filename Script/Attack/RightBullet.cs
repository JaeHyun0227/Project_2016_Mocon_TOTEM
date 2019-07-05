using UnityEngine;
using System.Collections;

public class RightBullet : MonoBehaviour {

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
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (transform.position.x >= Pos.x + 5.5)
        {
            Destroy(this.gameObject);
        }
    }
}
