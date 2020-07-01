using System.Collections;
using System.Collections.Generic;
//using System.Threading;
//using UnityEditorInternal;
using UnityEngine;

public class PatternMaker : MonoBehaviour
{
    public GameObject a_a, a_b, a_c, a_d, b_a, b_b, b_c, b_d, c_a, c_b, c_c, c_d, d_a, d_b, d_c, d_d, FList, FRay;
    public Material Blank, OnPattern;
    public List<GameObject> RandomList = new List<GameObject>();
    public PlayerOnClick POC;
    public AudioSource effect;

    public int X, Y;
    int randomX, randomY;
    int time;

    void Start()
    {
        POC = FindObjectOfType<PlayerOnClick>();
    }
    // Start is called before the first frame update
    public int PatternMakingX()
    {
        randomX = Random.Range(1, 4);

        return randomX;
    }

    public int PatternMakingY()
    {
        randomY = Random.Range(1, 4);

        return randomY;
    }

    public IEnumerator WaitFor2Sec(float sec, int difficulty)
    {
        for (int i = 0; i < difficulty; i++)
        {
            yield return new WaitForSeconds(sec);
            PatternOn();
            effect.Play();
            yield return new WaitForSeconds(sec);
            SetBlank();
            //yield return new WaitForSeconds(sec);
        }
    }

    public void PatternOn()
    {
        X = PatternMakingX();
        Y = PatternMakingY();

        switch (X)
        {
            case 1:
                {
                    switch (Y)
                    {
                        case 1:
                            {
                                a_a.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(a_a);
                                break;
                            }
                        case 2:
                            {
                                a_b.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(a_b);
                                break;
                            }
                        case 3:
                            {
                                a_c.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(a_c);
                                break;
                            }
                        case 4:
                            {
                                a_d.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(a_d);
                                break;
                            }
                    }
                    break;
                }
            case 2:
                {
                    switch (Y)
                    {
                        case 1:
                            {
                                b_a.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(b_a);
                                break;
                            }
                        case 2:
                            {
                                b_b.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(b_b);
                                break;
                            }
                        case 3:
                            {
                                b_c.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(b_c);
                                break;
                            }
                        case 4:
                            {
                                b_d.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(b_d);
                                break;
                            }
                    }
                    break;
                }
            case 3:
                {
                    switch (Y)
                    {
                        case 1:
                            {
                                c_a.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(c_a);
                                break;
                            }
                        case 2:
                            {
                                c_b.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(c_b);
                                break;
                            }
                        case 3:
                            {
                                c_c.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(c_c);
                                break;
                            }
                        case 4:
                            {
                                c_d.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(c_d);
                                break;
                            }
                    }
                    break;
                }
            case 4:
                {
                    switch (Y)
                    {
                        case 1:
                            {
                                d_a.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(d_a);
                                break;
                            }
                        case 2:
                            {
                                d_b.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(d_b);
                                break;
                            }
                        case 3:
                            {
                                d_c.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(d_c);
                                break;
                            }
                        case 4:
                            {
                                d_d.transform.GetComponent<MeshRenderer>().material = OnPattern;
                                RandomList.Add(d_d);
                                break;
                            }
                    }
                    break;
                }
        }
    }

    public void SetBlank()
    {
        a_a.transform.GetComponent<MeshRenderer>().material = Blank;
        a_b.transform.GetComponent<MeshRenderer>().material = Blank;
        a_c.transform.GetComponent<MeshRenderer>().material = Blank;
        a_d.transform.GetComponent<MeshRenderer>().material = Blank;

        b_a.transform.GetComponent<MeshRenderer>().material = Blank;
        b_b.transform.GetComponent<MeshRenderer>().material = Blank;
        b_c.transform.GetComponent<MeshRenderer>().material = Blank;
        b_d.transform.GetComponent<MeshRenderer>().material = Blank;

        c_a.transform.GetComponent<MeshRenderer>().material = Blank;
        c_b.transform.GetComponent<MeshRenderer>().material = Blank;
        c_c.transform.GetComponent<MeshRenderer>().material = Blank;
        c_d.transform.GetComponent<MeshRenderer>().material = Blank;

        d_a.transform.GetComponent<MeshRenderer>().material = Blank;
        d_b.transform.GetComponent<MeshRenderer>().material = Blank;
        d_c.transform.GetComponent<MeshRenderer>().material = Blank;
        d_d.transform.GetComponent<MeshRenderer>().material = Blank;
    }

    public bool ScoringOn(int difficulty)
    {
        for(int i = 0; i < difficulty; i++)
        {
            FList = RandomList[i];
            FRay = POC.RayList[i];

            if (FList != FRay)
                return false;
        }

        return true;
    }

}