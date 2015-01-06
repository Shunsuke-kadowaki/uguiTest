using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputTest : MonoBehaviour, IPointerEnterHandler {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerEnter(PointerEventData eventData) {
		Debug.Log (eventData);
		TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
	}
}
