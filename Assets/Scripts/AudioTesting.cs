using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioTesting : MonoBehaviour {
	// Get Device Audio
	// loudness modify
	public float sensitivity = 100;
	public float loudness = 0;
	private AudioSource _audio;
	GameObject guide;
	float timeSpan, checkTime;
	void Awake()
	{
		guide = GameObject.FindWithTag ("User");
		_audio = GetComponent<AudioSource>();
	}
	void Start()
	{
		
		guide.SetActive (false);
		timeSpan = 0.0f;
		checkTime = 5.0f;
		_audio.clip = Microphone.Start(null, true, 10, 44100);
		_audio.loop = true;
		_audio.mute = false;
		while (!(Microphone.GetPosition(null) > 0)) { }
		_audio.Play();
	}
	void Update()
	{
		loudnessCheck ();

	}

	float GetAveragedVolume()
	{
		float[] data = new float[256];
		float a = 0;
		_audio.GetOutputData(data, 0);
		foreach (float s in data)
		{
			a += Mathf.Abs(s);
		}
		return a / 256;
	}

	public void loudnessCheck()
	{
		loudness = GetAveragedVolume() * sensitivity;
		if(loudness > 25)
		{
			guide.SetActive (true);
			//DO SOMETHING
			Debug.Log("hello");
			StartCoroutine(guideDestroy ());
		}
	}

	IEnumerator guideDestroy(){
		yield return new WaitForSeconds (5.0f);
		guide.SetActive (false);
	}





}
