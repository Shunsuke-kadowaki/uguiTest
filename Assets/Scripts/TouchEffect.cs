using UnityEngine;
using System.Collections;

public class TouchEffect : MonoBehaviour {

	[SerializeField]
	private GameObject particle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI () {

		if (Event.current.type == EventType.MouseDown) {
			Vector3 clickPosition;
			clickPosition = Input.mousePosition;
			Debug.Log(clickPosition);
			clickPosition.z = 1.0f;

			GameObject effect = Instantiate(particle, Camera.main.ScreenToWorldPoint(clickPosition), Quaternion.identity) as GameObject;

			effect.particleSystem.Play ();

			ParticleAliveCheck pac = effect.AddComponent<ParticleAliveCheck>();

			pac.EventData += this.TouchEffectOn;

		}
	}

	public void TouchEffectOn(string testtext) {
		//touched = false;
		Debug.Log(testtext);
	}
}
