using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class madlibs : MonoBehaviour {

	public string[] userInputs = new string[10];
	

	// Use this for initialization
	void Start () {
        Debug.Log("Welcome to Madlibs! Please input your words in the inspector window, " +
            "then click on the game view and press the 'W' key to see your story come to life in the console!");
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.W))
        {
            finalString();
        }
	}
	void finalString()
	{
		string finalString = "";
        finalString += "On a sunny day, " + userInputs[0] + " and " + userInputs[1] + " spent the day in the park. ";
        finalString += " They were having a good time and they got lunch in the " +userInputs[2];
        finalString += ". When they went inside, they were surprised on what they saw! Inside was ";
        finalString += " "  + userInputs[3] + " eating " + userInputs[4] + "! They were really happy and they ";
        finalString += " don't want to leave! " +userInputs[0] + " said, 'We need a picture of " + userInputs[3];
        finalString += " . Our friends will be jealous!' " + userInputs[1] + " walked up to " +userInputs[3];
        finalString += " and said, 'Hi. Can we take a picture with you? " + userInputs[3] + " said, 'Sure.' ";
        finalString += " They took the picture, and all of a sudden, a big " + userInputs[5] + " came out of nowhere and ";
        finalString += " attacked both " +userInputs[0]+ " and " + userInputs[1] +  ". They screamed  " +userInputs[6]+ "! " +userInputs[3];
        finalString += " called " +userInputs[7] + " and they pulled the " + userInputs[5] + "away ";
        finalString += "The " + userInputs[5] + "ran away and " + userInputs[0] + " and " + userInputs[1] + " are injured. ";
        finalString += "When they got to the " + userInputs[8] + " they both said, 'That was the best day of our lives!' ";
        finalString += "The were chilling in the  " + userInputs[8] + " all of a sudden, another big " + userInputs[9];
        finalString += "came out of nowhere and killed both " +userInputs[0] + " and " +userInputs[1]+ ".";
        Debug.Log(finalString);
    }
}
