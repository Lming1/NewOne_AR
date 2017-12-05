using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClk : MonoBehaviour {

    GameObject m_all;
    public float v_size;
    public float v_pos;
    public float m_sizeX;
    public float m_sizeY;

    // Use this for initialization
    void Start () {
        m_all = GameObject.FindGameObjectWithTag("m_all");
        m_sizeX = m_all.transform.localScale.x;
        m_sizeY = m_all.transform.localScale.y;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void sizeUp()
    {
        m_all.transform.localScale = new Vector3(m_all.transform.localScale.x + v_size, 0, m_all.transform.localScale.z + v_size);
    }

    public void sizeDown()
    {
        m_all.transform.localScale = new Vector3(m_all.transform.localScale.x - v_size, 0, m_all.transform.localScale.z - v_size);
    }

    public void posUp()
    {
        m_all.transform.position = new Vector3(0, 0, m_all.transform.position.z + v_pos);
    }

    public void posDown()
    {
        m_all.transform.position = new Vector3(0, 0, m_all.transform.position.z - v_pos);
    }
}
