using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EventSystemTest : MonoBehaviour, IPointerClickHandler {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerClick (PointerEventData eventData) {

		Debug.Log (eventData);

		if(Time.timeScale <= 0) {
			this._StartRotate();
		} else {
			this._StopRotate();
		}

	}

	private void _StopRotate() {
		Time.timeScale = 0;
	}

	private void _StartRotate() {
		Time.timeScale = 1;
	}
}
