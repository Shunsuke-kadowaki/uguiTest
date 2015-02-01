using UnityEngine;
using System.Collections;

public delegate void ParticleHandler(string textdata);

public class ParticleAliveCheck : MonoBehaviour {

	public event ParticleHandler EventData;

	void LateUpdate() {
		if(!particleSystem.IsAlive()) {
			this.EventData("SendTest");
			Destroy(gameObject);
		}
	}
}
