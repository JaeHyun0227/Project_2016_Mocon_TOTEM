using UnityEngine;
using System.Collections;

public class LeftStoneAttack : MonoBehaviour
{

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
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= Pos.x - 2.5)
        {
            Destroy(this.gameObject);
        }
    }
}
