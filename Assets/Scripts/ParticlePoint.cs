using UnityEngine;
using System.Collections;

public class ParticlePoint : MonoBehaviour {

	public enum ElementType {
		EARTH,
		WATER,
		LAVA,
		ICE
	}
	
	public ElementType type;
	public float particleSize;

	Vector3 position;
	bool isSupported;

	void Start () {
		position = transform.position;
		isSupported = true;
		switch(type) {
		case ElementType.EARTH:
			particleSize = 5.0f;
			break;
		default:
			particleSize = 1.0f;
			break;
		}
	}
	
	void Update () {
	}
}