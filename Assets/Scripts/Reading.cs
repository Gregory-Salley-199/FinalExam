﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class Reading : MonoBehaviour
{
    public Text fileContents;


    public void ReadString() //NEED TO MAKE THIS PUBLIC SO WE CAN CONNECT TO BUTTON
    {

        string path = "Assets/scores.txt";
        string lineRead = "";
        fileContents.text = "";

        //Read the text from directly from the scores.txt file
        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            //Debug.Log(reader.ReadLine());
            lineRead = reader.ReadLine();
            Debug.Log(lineRead);
            fileContents.text += lineRead + "\n"; // append and go to new line
        }
        reader.Close();


    }

}