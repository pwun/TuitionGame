using UnityEngine;
using System.Collections;
using System.Reflection;

public class Generator {

	public Generator(){
	}

	public Entry Generate(string _methodName){
		if (this.GetType ().GetMethod (_methodName) != null) {
			MethodInfo mi = this.GetType ().GetMethod (_methodName);
			return (Entry)mi.Invoke (this, null);
		} else {
			return Fallback ();
		}
	}

	public Entry Ungleichung1(){
		float a = (float)System.Math.Round(Random.Range (-5.00f, 5.00f),2);
		float b = (float)System.Math.Round(Random.Range (-5.00f, 5.00f),2);
		string question = a + "___" + b;
		string answer;
		if (a == b) {
			answer = "=";
		}
		else if (a < b) {
			answer = "<";
		}
		else answer = ">";
		return new Entry (question, answer, "Füge das richtige Ungleichungszeichen ein (<, >, oder =):");
	}


	//fallback entry in case a method isn't found by name
	private Entry Fallback(){
		int a = Random.Range (0, 10);
		int b = Random.Range (0, 10);
		int c = Random.Range (0, 10);
		string question = a + "+" + b + "*" + c + "=";
		string answer = a + b * c + "";
		return new Entry (question, answer, "Berechne als Ganzzahl:");
	}

}
