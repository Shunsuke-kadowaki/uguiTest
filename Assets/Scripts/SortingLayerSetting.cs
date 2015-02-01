using UnityEngine;
using System.Collections;

public class SortingLayerSetting : MonoBehaviour {

	//sorting layer set
	[SerializeField]
	private string _sortingLayerName = "Default";

	// Use this for initialization
	void Start () {
		renderer.sortingLayerName = _sortingLayerName;
	}
	

}
