using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour {

    public GameObject confirm;
    public GameObject choose;
	// Use this for initialization
	void Start () {
        confirm.GetComponent<Button>().onClick.AddListener(Confirm);
        choose.GetComponent<Button>().onClick.AddListener(Choose);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Confirm(){
        if(transform.GetChild(2).GetChild(0).GetComponent<Text>().text=="请观察模型"){
            transform.GetChild(2).GetChild(0).GetComponent<Text>().text = "请开始复现模型";
        }else{
            this.gameObject.SetActive(false);
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("LEGODemo"))
            {
                obj.SetActive(false);
            }
        }
    }

    void Choose(){
        transform.GetChild(3).gameObject.SetActive(false);
    }
}
