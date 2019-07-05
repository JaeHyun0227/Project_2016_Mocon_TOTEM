using UnityEngine;
using System.Collections;

public class RightSunBullet : MonoBehaviour {

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
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (transform.position.x >= Pos.x + 7.5 || stack >= 3)
        {
            Destroy(this.gameObject);
        }
    }
}

