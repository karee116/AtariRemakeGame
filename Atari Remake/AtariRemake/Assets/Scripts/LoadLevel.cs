using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public void LoadStage()
	{
		Application.LoadLevel(1);
	}
	
	public void Retry ()
	{
		Application.LoadLevel(0);
	}
	
	public void Exit ()
	{
		Application.Quit();
	}
}
