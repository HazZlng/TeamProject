using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnClick : MonoBehaviour
{
    public GameObject obj;
    public Material OnClick;
    public Material OnPattern;
    public Material Blank;
    public AudioSource effect;
    public List<GameObject> RayList = new List<GameObject>();

    //GameManager GM = new GameManager();

    float MaxDistance = 10.0f;
    //int clickCount = 3;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, MaxDistance);

            if (hit.collider != null)
            {
                effect.Play();
                hit.transform.GetComponent<MeshRenderer>().material = OnClick;
                obj = hit.transform.gameObject;
                RayList.Add(obj);
            }

        }

        /*
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, MaxDistance);


            if (hit.collider != null)
            {
                hit.transform.GetComponent<MeshRenderer>().material = OnPattern;
            }
        }

        if (Input.GetMouseButtonDown(2))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, MaxDistance);


            if (hit.collider != null)
            {
                hit.transform.GetComponent<MeshRenderer>().material = Blank;
            }
        }
        */
    }
}