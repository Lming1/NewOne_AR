using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour {
	public static Color defaultColor;
	public static Color selectedColor;
	public static Material mat;

    public GameObject target;
    
    public int st_color = 1;
    public int nd_color;
    public Renderer rend;
    public Material[] matA = new Material[19];
    // Use this for initialization
    void Start () {

        rend = target.GetComponent<Renderer>();
        rend.enabled = true;

        mat = GetComponent<Renderer> ().material;

		mat.SetFloat("_Mode", 2);
		mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
		mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
		mat.SetInt("_ZWrite", 0);
		mat.DisableKeyword("_ALPHATEST_ON");
		mat.EnableKeyword("_ALPHABLEND_ON");
		mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
		mat.renderQueue = 3000;

		defaultColor = new Color32 (255, 255, 255, 255);
		selectedColor = new Color32 (255, 0, 0, 255);

		//mat.color = defaultColor;


	}

    /*
	void touchBegan(){
		mat.color = selectedColor;
	}

	void touchStay(){
		mat.color = selectedColor;
	}

	void touchExit(){
		mat.color = selectedColor;
	}
    */

    void touchEnded()
    {
        if (st_color <= nd_color)
        {
            rend.sharedMaterial = matA[st_color];
            st_color++;
        }
        else
        {
            st_color = 1;
            rend.sharedMaterial = matA[st_color];
        }
            
    }
}
