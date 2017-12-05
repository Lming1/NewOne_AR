using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleSlider : MonoBehaviour {

    GameObject m_all;
    static Vector3 oriSize;
    public Slider progress;
	// Use this for initialization
	void Start () {
        m_all = GameObject.FindGameObjectWithTag("m_all");
        oriSize = m_all.transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeScale()
    {
        m_all.transform.localScale = oriSize * progress.value;
    }
}
