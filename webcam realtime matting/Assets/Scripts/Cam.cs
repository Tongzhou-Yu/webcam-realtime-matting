using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour
{
	public string Mydevice;
	WebCamTexture tex;

	// Use this for initialization
	IEnumerator Start()
	{
		yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
		if (Application.HasUserAuthorization(UserAuthorization.WebCam))
		{
			WebCamDevice[] devices = WebCamTexture.devices;
			Mydevice = devices[0].name;
			tex = new WebCamTexture(Mydevice, 400, 300, 12);
			this.GetComponent<Renderer>().material.mainTexture = tex;
			tex.Play();
		}
	}

	// Update is called once per frame
	void Update()
	{


	}

}
