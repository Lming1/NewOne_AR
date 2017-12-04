using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lipsticks : MonoBehaviour {

    GameObject lip;
    public int st_lip_color = 1;
    public Renderer rend;
    public Material[] matA = new Material[6];
    
    // Use this for initialization
    void Start () {
        lip = GameObject.FindGameObjectWithTag("lip");
        rend = lip.GetComponent<Renderer>();
        rend.enabled = true;
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void touchEnded()
    {
        Debug.Log("터치!");
        if (st_lip_color <= 5)
        {
            rend.sharedMaterial = matA[st_lip_color];
            st_lip_color++;
        }
        else
        {
            st_lip_color = 1;
            rend.sharedMaterial = matA[st_lip_color];
        }

    }
}
