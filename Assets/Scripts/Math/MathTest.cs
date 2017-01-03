using UnityEngine;
using System.Collections;

public class MathTest : MonoBehaviour {

	Generator Gen;
	// Use this for initialization
	void Start () {
		Gen = new Generator ();
		for (int i = 0; i < 10; i++) {
			RandomTest ();
		}
	}

	private void RandomTest(){
		Entry e = Gen.Generate ("Ungleichung1");
		int i = Random.Range (0, 100);
		Debug.Log (e.ToString ());
		Debug.Log ("Eingabe: <\t\t\tErgebnis: " + e.CheckAnswer ("<"));
	}
}
