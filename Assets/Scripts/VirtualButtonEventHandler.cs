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
		// Register button presed
		case "register":
			Application.OpenURL ("http://2016.echacks.xyz/apply.html");
			break;
		}
	}

	// Called when the virtual button has just been released
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
	{
		
	}


}
