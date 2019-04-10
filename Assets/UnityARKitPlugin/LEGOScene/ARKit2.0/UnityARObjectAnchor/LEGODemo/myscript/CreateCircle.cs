using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCircle : MonoBehaviour {

    public GameObject circle;
    public bool isfound = false;
    public bool isread = false;
    int i = 0;
    Vector3 temppos;
    //public Text text1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isfound == true)
        {
            Debug.Log(111);
            if (isread == false)
            {
                //Debug.Log(Camera.main.transform.position);
                //Debug.Log(Camera.main.transform.forward);
                if (i == 0)
                {
                    i = 1;
                    GameObject circlone = GameObject.Instantiate(circle);
                    circlone.transform.position = Camera.main.transform.position + Camera.main.transform.forward *90f;
                    circlone.transform.localScale = new Vector3(1f, 1f, 1f);
                    temppos = circlone.transform.position;
                }
                else
                {
                    GameObject circlone = GameObject.Instantiate(circle);
                    //Debug.Log(Camera.main.transform.position);
                    circlone.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 90f;
                    circlone.transform.localScale = new Vector3(1f, 1f, 1f);
                    //text1.text = (circlone.transform.position - temppos).ToString();

                    if ((circlone.transform.position - temppos).magnitude > 0.1f)
                    {
                        temppos = circlone.transform.position;
                    }
                    else
                    {
                        Destroy(circlone);
                    }
                }

            }           

        }
    }

    public void creatRoadline(Vector3 pos) {
        GameObject circlone = GameObject.Instantiate(circle);
        circlone.transform.position = pos;
        circlone.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
