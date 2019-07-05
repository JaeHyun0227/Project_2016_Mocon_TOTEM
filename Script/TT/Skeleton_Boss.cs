using UnityEngine;
using System.Collections;

public class Skeleton_Boss : MonoBehaviour {

    Animator Animator;
    public SPEEDUP SPEEDUP;
    public Money money;
    public WaveStartButton cnt;
    public GameObject Pos1, Pos2, Pos3, Pos4, Pos5;
    public GameObject Monster;
    public Health Hp;
    public Vector3 Target;
    public int M_HP = 50;
    public int Cnt;
    public float speed;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "BulletDestroy")
        {
            Destroy(col.gameObject);
            M_HP -= 5;
        }
        if (col.gameObject.tag == "Attack")
        {
            Destroy(col.gameObject);
            M_HP -= 10;
        }
        if (col.gameObject.tag == "SunStack")
        {
            M_HP -= 3;
        }
        if (col.gameObject.tag == "Lazer")
        {
            M_HP -= 8;
        }
    }
    void Start()
    {
        Cnt = 0;
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(M_HP <= 0)
        {
            money.money += 2;
            cnt.cnt-=2;
            Destroy(this.gameObject);
        }
        speed = SPEEDUP.speed /2;

        float step = speed * Time.deltaTime;


        if (Cnt == 0)
        {
            Target = Pos1.transform.position;
            Target.y += 0.5f;
            Move(Target, step);
            if (Target == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 1)
        {
            Animator.SetInteger("Cnt", 1);

            Target = Pos2.transform.position;
            Target.y += 0.5f;


            Move(Target, step);
            if (Target == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 2)
        {
            Animator.SetInteger("Cnt", 2);

            Target = Pos3.transform.position;
            Target.y += 0.5f;

            Move(Target, step);
            if (Target == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 3)
        {
            Animator.SetInteger("Cnt", 3);

            Target = Pos4.transform.position;
            Target.y += 0.5f;

            Move(Target, step);
            if (Target == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 4)
        {
            Animator.SetInteger("Cnt", 4);

            Target = Pos5.transform.position;
            Target.y += 0.5f;

            Move(Target, step);
            if (Target == transform.position)
            {
                Hp.HP -= 20;
                cnt.cnt-=2;
                Destroy(Monster);
            }
        }
    }

    void Move(Vector3 target, float step)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
