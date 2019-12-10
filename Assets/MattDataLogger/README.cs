using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class README : MonoBehaviour {

}

/*
 
NOTE - only use a NUMBER for participant ID - so a specific human can never be identified from the logged data
the experiment data is then anonymized which means you can do what you like with it, including publishing it

on paper, and filed safely by _you_ the experimenter, can be a reference list of participant's personal details and their allocated user ID

something I do sometimes, so the ID doesn't even indicate the SEQUENCE of users, is to randomly allocated a number from 1-100 to each participant
(with no duplicate IDs of course)

--------
step 1: Create folder to store log files
Create a folder "Logs" in your project

--------
step 2: Scene with button to create new file with given User ID

- create a new scene "scene0_startExperiment"
- save the scene, and add to the Build settings- ensure this is gthe FIRST scene in the list

- create a UI Input text - for entering User ID
- add to the Text GameObject of the Input Text an instance of script ScreenToFile

- create a button labelled Create New Log File with User ID
- add to button an OnCLick handler, linked to the Text GameObject of the Input Text - that calls the method: BUTTON_ACTION_CreateTextFileWithUserId()

to use this scene:
- run scene
- type in a user ID (e.g. 22)
- click the button

you should see new file crated in Logs folder 
(note - it takes 10-20 seconds for Unity to see new file, but if you view folder contents in Windows you'll see the log file immediately)

--------
step 3: Buttons / scripts to log text messages / actions to the Log file

anywhere in hour game you can use this line to append a new message to the log file:

	string message = "user picked up a brick!";
	AddToLogFile.LogLine( message );

--------
that's it!

the log file are TEXT, with file extension ".csv" - so they should load into Excel easily for analysis / charting etc.

you could take things further and log all data into a database for analysis after experiment is complete
- I can help with that if needed ...

*/