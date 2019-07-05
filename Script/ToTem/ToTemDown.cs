using UnityEngine;
using System.Collections;

public class ToTemDown : MonoBehaviour {

    public Diamond Dia;
    public WoodBuild WoodB;
    public MelonBuild MelonB;
    public MushroomBuild MushroomB;
    public StoneBuild StoneB;
    public SunBuild SunB;
    public BirdBuild BirdB;
    public SPEEDUP SPEEDUP;
    public GameObject B;
    public GameObject Attack;
    public GameObject SunShot;
    public GameObject Lazer;
    public GameObject[] Build = new GameObject[6];
    Animator Animator;
    public int Check;
    public int i = 0;

    // Use this for initialization
    void Start()
    {
        Animator = GetComponent<Animator>();//나한테 달린 애니메이터 값을 조정한다 
        Check = 0;
        Animator.SetInteger("방향", 3);
    }

    // Update is called once per frame
    void Update()
    {

        if (Check >= 2)
        {
            i++;
        }
        if (i >= SPEEDUP.bulletspawn && Check == 2)
        {
            B.SetActive(true);
            Instantiate(B, this.transform.position, Quaternion.identity);
            B.SetActive(false);
            i = 0;
        }
        if (i >= SPEEDUP.bulletspawn && Check == 3)
        {
            Vector3 pos = transform.position;
            B.SetActive(true);
            Instantiate(B, pos, Quaternion.identity);
            pos.x += 0.5f;
            Instantiate(B, pos, Quaternion.identity);
            pos.x -= 1f;
            Instantiate(B, pos, Quaternion.identity);
            B.SetActive(false);
            i = 0;
        }
        if (i >= SPEEDUP.AttackTime && Check == 4)
        {
            Attack.SetActive(true);
            Instantiate(Attack, this.transform.position, Quaternion.identity);
            Attack.SetActive(false);
            i = 0;
        }
        if (i >= SPEEDUP.bulletspawn && Check == 5)
        {
            SunShot.SetActive(true);
            Instantiate(SunShot, this.transform.position, Quaternion.identity);
            SunShot.SetActive(false);
            i = 0;
        }
        if (i >= SPEEDUP.bulletspawn * 2 && Check == 6)
        {
            Lazer.SetActive(true);
            Instantiate(Lazer, this.transform.position, Quaternion.identity);
            Lazer.SetActive(false);
            i = 0;
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && WoodB.WoodB == true && Check == 0)
        {
            Dia.Dia -= 5;
            Animator.SetBool("각목", true);
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

            WoodB.WoodB = false;
            WoodB.Check = false;
            Check = 1;
            Build[Check - 1].transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
        }
        if (Input.GetMouseButtonDown(0) && MelonB.MelonB == true && Check == 1)
        {
            Dia.Dia -= 5;
            Animator.SetInteger("Value", 1);
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            MelonB.MelonB = false;
            WoodB.Check = false;
            Check = 2;
            Build[Check - 1].transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
        }
        if (Input.GetMouseButtonDown(0) && MushroomB.MushroomB == true && Check == 1)
        {
            Dia.Dia -= 15;
            Animator.SetInteger("Value", 2);
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            MushroomB.MushroomB = false;
            WoodB.Check = false;
            Check = 3;
            Build[Check - 1].transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
        }
        if (Input.GetMouseButtonDown(0) && StoneB.StoneB == true && Check == 1)
        {
            Dia.Dia -= 25;
            Animator.SetInteger("Value", 3);
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            StoneB.StoneB = false;
            WoodB.Check = false;
            Check = 4;
            Build[Check - 1].transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
        }
        if (Input.GetMouseButtonDown(0) && SunB.SunB == true && Check == 1)
        {
            Dia.Dia -= 25;
            Animator.SetInteger("Value", 4);
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            SunB.SunB = false;
            WoodB.Check = false;
            Check = 5;
            Build[Check - 1].transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
        }
        if (Input.GetMouseButtonDown(0) && BirdB.BirdB == true && Check == 1)
        {
            Dia.Dia -= 35;
            Animator.SetInteger("Value", 5);
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            BirdB.BirdB = false;
            WoodB.Check = false;
            Check = 6;
            Build[Check - 1].transform.localScale = new Vector3(0.02f, 0.065f, 0.065f);
        }
    }
}
