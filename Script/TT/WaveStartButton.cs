using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
using UnityEngine.UI;


public class WaveStartButton : MonoBehaviour {

    public float spawnTime;
    public string num;
    public GameObject Monster;
    public GameObject MonsterBoss;
    public SPEEDUP SPEEDUP;
    public Health Hp;
    public Sprite S1,S2;
    public GameObject Win, Lose,Page;
    public bool CoolTime;
    public int wave;
    public int cnt;

    // Use this for initialization
	void Start () {
        CoolTime = false;
        wave = 0;
        spawnTime = 1;
        Monster.SetActive(false);
        MonsterBoss.SetActive(false);
    }

    Vector3 SetPos()
    {
        float posX = -0.1f;
        float posy = 0.85f;
        float posz = 50f;


        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(posX, posy, posz));
        return pos;
    }

    // Update is called once per frame
    void Update () {
        spawnTime = SPEEDUP.spawnTime;


        if(wave==4 && cnt == -1 && Hp.HP >= 1)
        {
            Page.SetActive(true);
            Win.SetActive(true);
        }
        else if(Hp.HP <= 0)
        {       
            Page.SetActive(true);
            Lose.SetActive(true);
        }
    }

    IEnumerator OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && CoolTime == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S2;
            CoolTime = true;
            wave++;
            Wave();


            yield return new WaitForSeconds(30);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = S1;
            CoolTime = false;


        }
    }

    IEnumerator Skeletonspawn(int cnt)
    {
        int i = 1;
        while (i++ <= cnt)
        {
            yield return new WaitForSeconds(spawnTime);
            Monster.SetActive(true);
            Instantiate(Monster, SetPos(), Quaternion.identity);
            Monster.SetActive(false);
        }

    }
    
    IEnumerator SkeletonBossSpawn()
    {

        Vector3 pos = SetPos();
        pos.y += 0.5f;

        yield return new WaitForSeconds(spawnTime);
        MonsterBoss.SetActive(true);
        Instantiate(MonsterBoss, pos, Quaternion.identity);
        MonsterBoss.SetActive(false);
    }

    void Wave()
    {
        if (wave == 1)
        {
            cnt += 10;
            StartCoroutine(Skeletonspawn(10));
        }
        if (wave == 2)
        {
            cnt += 15;
            StartCoroutine(Skeletonspawn(15));
        }
        if (wave == 3)
        {
            cnt += 20;
            StartCoroutine(Skeletonspawn(20));
        }
        if (wave == 4)
        {
            cnt += 21;
            StartCoroutine(Skeletonspawn(20));
            StartCoroutine(SkeletonBossSpawn());
        }
    }
}
