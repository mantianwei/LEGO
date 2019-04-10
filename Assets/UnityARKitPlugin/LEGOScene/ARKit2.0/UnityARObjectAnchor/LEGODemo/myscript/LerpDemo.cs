using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{

    private Vector3 m_vFrom = new Vector3(0.008f, 0.008f, 0.008f);
    private Vector3 m_vTo = new Vector3(0.015f, 0.015f, 0.015f);

    private float m_fTime = 0;
    private bool add = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (m_fTime >= 1)
        {
            add = false;
            Debug.Log(111);
        }
        if (m_fTime <= 0)
        {
            add = true;
            Debug.Log(222);
        }
        if(add){
            m_fTime += Time.deltaTime;
        }else{
            m_fTime -= Time.deltaTime;
        }
        transform.localScale = Vector3.Lerp(m_vFrom, m_vTo, m_fTime);
    }

}
