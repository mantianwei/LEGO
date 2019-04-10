using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour {

    public Button I;
    public Button O;
    public Button S;
    public Button E;
    public Text text2;
    Object[] m_sphere;
    int j;
    List<string> Allmytxt = new List<string>();

    // Use this for initialization
    void Start () {
        I.onClick.AddListener(writeRoadline);
        O.onClick.AddListener(readRoadline);
        S.onClick.AddListener(StartS);
        E.onClick.AddListener(EndS);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void writeRoadline() {
        //m_sphere = GameObject.FindGameObjectsWithTag("sphere");
        //text2.text =  text2.text + " " + i.ToString() ;
        //text2.text = m_sphere.Length.ToString();

        m_sphere = Resources.FindObjectsOfTypeAll(typeof(Transform));

        GetComponent<mytxtIO>().ClearTxt();
        foreach(Transform tran in m_sphere)
        {
            Debug.Log(tran.name);
            if (tran.name == "Sphere(Clone)")
            {
                GetComponent<mytxtIO>().WriteIntoTxt(tran.transform.position.ToString());
                text2.text = text2.text + " " + tran.transform.position.ToString();
            }
            
        }
    }

    public void readRoadline()
    {
        Allmytxt = GetComponent<mytxtIO>().GetmytxtList();
        foreach (string line in Allmytxt)
        {
            string temp = line.Replace("(", "").Replace(")", "");
            string[] s = temp.Split(',');
            Vector3 v3=new Vector3(float.Parse(s[0]), float.Parse(s[1]), float.Parse(s[2]));
            GetComponent<CreateCircle>().creatRoadline(v3);
        }

        GetComponent<CreateCircle>().isread = true;
    }

    void StartS(){
        GetComponent<CreateCircle>().isfound = true;
    }
    void EndS()
    {
        GetComponent<CreateCircle>().isfound = false;
    }
}
