using UnityEngine;
using System.Collections;

public class CheckKinect : MonoBehaviour {
	public Texture disabledKinect;
	private bool dis;

	void Start()
	{
		KinectManager instance = KinectManager.Instance;
		if (instance!=null)
		{


						//dis = instance.IsKinectInitialized ();
				}
	}

	void OnGUI() {
		print ("kinect: " + dis);
		if (!dis) {
			GUI.DrawTexture (new Rect (50, 50, 60, 60), disabledKinect);
			GUI.Label (new Rect (120, 50, 200, 50), "Kinect is not connected. Use arrows and keys f(front) and b(back) instead.");

		}
	
	}
	
	// Update is called once per frame

}
