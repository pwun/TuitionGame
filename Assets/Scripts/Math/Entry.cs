using UnityEngine;
using System.Collections;

public class Entry {

	public string description;
	public string question;
	public string answer;

	public Entry(string _question, string _answer, string _description){
		question = _question;
		answer = _answer;
	}

	public bool CheckAnswer(string _answer){
		return answer.Equals (_answer.Trim());
	}

	public override string ToString(){
		return "Question: " + question + "|\tAnswer: " + answer;
	}
}
