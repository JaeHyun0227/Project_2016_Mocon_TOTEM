using UnityEngine;
using System.Collections;

public class Skeleton_TT : MonoBehaviour {

    Animator Animator;
    public SPEEDUP SPEEDUP;
    public GameObject Pos1,Pos2,Pos3,Pos4,Pos5;
    public GameObject Monster;
    public Health HP;
    public WaveStartButton cnt;
    public Money money;
    public int M_HP = 10;
    public int Cnt;
    public float speed;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if( col.gameObject.tag == "BulletDestroy")
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
        if(col.gameObject.tag == "Lazer")
        {
            M_HP -= 8;
        }
    }
    void Start () {
        Cnt = 0;
        Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(M_HP <= 0)
        {
            money.money += 2;
            cnt.cnt--;
            Destroy(this.gameObject);
        }

        speed = SPEEDUP.speed;

        float step = speed * Time.deltaTime;



        if (Cnt == 0)
        {
            Move(Pos1.transform.position, step);
            if(Pos1.transform.position == transform.position)
            {
                Cnt++;
            }
        }
        if(Cnt == 1)
        {
            Animator.SetInteger("Cnt", 1);

            Move(Pos2.transform.position, step);
            if(Pos2.transform.position == transform.position)
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
                cnt.cnt--;
                HP.HP -= 5;
                Destroy(Monster);
            }
        }
    }

    void Move(Vector3 target,float step)
    {

        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

}
