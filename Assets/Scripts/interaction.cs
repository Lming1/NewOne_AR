using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour {
	public static Color defaultColor;
	public static Color selectedColor;
	public static Material mat;
	// Use this for initialization
	void Start () {
		
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
		selectedColor = new Color32 (0, 0, 0, 0);

		mat.color = defaultColor;
	}

	void touchBegan(){
		mat.color = selectedColor;
		Debug.Log ("selected");
	}

	void touchEnded(){
		mat.color = defaultColor;
		Debug.Log ("end");
	}

	void touchStay(){
		mat.color = selectedColor;
		Debug.Log ("stay");
	}

	void touchExit(){
		mat.color = defaultColor;
		Debug.Log ("end");
	}
}
