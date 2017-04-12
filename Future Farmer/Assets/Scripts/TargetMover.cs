using UnityEngine;
using System.Collections;

public class TargetMover : MonoBehaviour {


	// define the possible states through an enumeration
	public enum motionDirections {Spin,Horizontal, Vertical};
	
	// store the state
	public motionDirections motionState = motionDirections.Horizontal;

	// motion parameters
	public float spinSpeed = 10.0f;
	public float motionMagnitude = 10.0f;

	/// Update is called once per frame
	void Update () {

		//gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		//gameObject.transform.Translate(Vector3.right * Time.deltaTime * motionMagnitude);
		gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		var myObj = GameObject.Find("cat_Idle");
		//debugDebug.Log (gameObject.transform.position.z);
		//Debug.Log (myObj.transform.position.x);
		if (myObj!=null && gameObject.transform.position.x - myObj.transform.position.x <=1 && gameObject.transform.position.z - myObj.transform.position.z <=1)
			Destroy (myObj);
		//Debug.Log (gameObject);
		//gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
		// do the appropriate motion based on the motionState
		/*switch(motionState) {
			case motionDirections.Spin:
				// rotate around the up axix of the gameObject
				gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
				break;
			case motionDirections.Horizontal:
				// move up and down over time
				gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				break;
			case motionDirections.Vertical:
				// move up and down over time
				gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				break;*/
		}
	}

