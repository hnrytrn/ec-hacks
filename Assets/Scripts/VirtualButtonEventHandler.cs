/*============================================================================== 
 * Copyright (c) 2012-2015 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/
using UnityEngine;
using System;
using System.Collections.Generic;
using Vuforia;

/// <summary>
/// This class implements the IVirtualButtonEventHandler interface and
/// contains the logic to swap materials for the teapot model depending on what 
/// virtual button has been pressed.
/// </summary>
public class VirtualButtonEventHandler : MonoBehaviour,
IVirtualButtonEventHandler
{
	void Start()
	{
		// Register the virtual buttons
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i)
		{
			vbs[i].RegisterEventHandler(this);
		}
	}
		
	/// Called when the virtual button has just been pressed
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);

		switch (vb.VirtualButtonName) {
		// EC Register button presed
		case "ecregister":
			Application.OpenURL ("http://2016.echacks.xyz/apply.html");
			break;
		
		// MF apply button
		case "mfapply":
			Application.OpenURL ("https://www.magnetforensics.com/careers/");
			break;
		// MLH hack button
		case "mlhhack":
			Application.OpenURL ("https://mlh.io/seasons/na-2017/events");
			break;
		// facebook ec hacks button
		case "fbec":
			Application.OpenURL ("https://www.facebook.com/echacks/");
			break;
		// facebook magnet forensics  button
		case "fbmagnet":
			Application.OpenURL ("https://www.facebook.com/pages/Magnet-Forensics/204871079688864");
			break;
		// facebook mlh button
		case "fbmlh":
			Application.OpenURL ("https://www.facebook.com/MajorLeagueHacking/");
			break;
		}
	}

	// Called when the virtual button has just been released
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
	{
	}


}
