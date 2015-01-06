using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowModalWindow : MonoBehaviour {

	private GameObject ModalWindow;

	// Use this for initialization
	void Start () {
		ModalWindow = GameObject.Find ("ModalWindow");
		ModalWindow.GetComponent<Canvas> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenModalWindow() {
		ModalWindow.GetComponent<Canvas> ().enabled = true;
	}

	public void CloseModalWindow() {
		ModalWindow.GetComponent<Canvas> ().enabled = false;
	}

}
