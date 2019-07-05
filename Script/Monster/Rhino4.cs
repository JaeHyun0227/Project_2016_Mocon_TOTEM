using UnityEngine;
using System.Collections;

public class Rhino4 : MonoBehaviour {

    Animator Animator;
    public SPEEDUP SPEEDUP;
    public GameObject Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8, Pos9;
    public GameObject Monster;
    public WaveStartButton_1_9 cnt;
    public Money money;
    public int M_HP = 20;
    public Health HP;
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
        if (M_HP <= 0)
        {
            money.money += 2;
            cnt.cnt -= 2;
            Destroy(this.gameObject);
        }
        speed = SPEEDUP.speed;

        float step = speed * Time.deltaTime;



        if (Cnt == 0)
        {
            Move(Pos1.transform.position, step);
            if (Pos1.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 1)
        {
            Animator.SetInteger("Cnt", 1);

            Move(Pos2.transform.position, step);
            if (Pos2.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 2)
        {
            Animator.SetInteger("Cnt", 2);

            Move(Pos3.transform.position, step);
            if (Pos3.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 3)
        {
            Animator.SetInteger("Cnt", 3);

            Move(Pos4.transform.position, step);
            if (Pos4.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 4)
        {
            Animator.SetInteger("Cnt", 4);

            Move(Pos5.transform.position, step);
            if (Pos5.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 5)
        {
            Animator.SetInteger("Cnt", 5);

            Move(Pos6.transform.position, step);
            if (Pos6.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 6)
        {
            Animator.SetInteger("Cnt", 6);

            Move(Pos7.transform.position, step);
            if (Pos7.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 7)
        {
            Animator.SetInteger("Cnt", 7);

            Move(Pos8.transform.position, step);
            if (Pos8.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if (Cnt == 8)
        {
            Animator.SetInteger("Cnt", 8);

            Move(Pos9.transform.position, step);
            if (Pos9.transform.position == transform.position)
            {
                cnt.cnt--;
                HP.HP -= 5;
                Destroy(Monster);
            }
        }
    }

    void Move(Vector3 target, float step)
    {

        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

}
