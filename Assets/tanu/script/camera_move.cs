using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject targetObject;

	// starting value for the Lerp
	static float t = 0.015f;

	void Update()
	{
		// animate the position of the game object...
		Vector2 camera_position = this.transform.position;
		Vector2 player_position = targetObject.transform.position;
		transform.position = new Vector3(Mathf.Lerp(camera_position.x, player_position.x, t), Mathf.Lerp(camera_position.y, player_position.y, t), -1);
	}
}
