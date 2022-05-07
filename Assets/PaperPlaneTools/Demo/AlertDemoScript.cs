using UnityEngine;
using System.Collections;

using System;
using PaperPlaneTools;
using UnityEngine.UI;

public class AlertDemoScript : MonoBehaviour 
{
	public GameObject alertNativeWindow;

	public void OnButtonShowNativeWindow() {
		// Simple native alert with button handler
		new Alert ("Hello", "Hello, world")
			.SetPositiveButton ("OK", () => {
				Debug.Log("Ok handler");
			})
			.Show ();
	}

	public void OnButtonQueueTest() 
	{
		// #2 alert will be displayed after #1 is dismissed
		new Alert ("Hello", "#1 in queue")
			.SetPositiveButton ("OK")
			.Show ();
		new Alert ("Hello", "#2 in queue")
			.SetPositiveButton ("OK")
			.Show ();

	}
}
