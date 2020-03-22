using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ASCII_Level_Loader : MonoBehaviour
{
    public GameObject wall;
    public GameObject wall1;
    public GameObject player;
    public GameObject prize;

    public float xOffset = -5;
    public float yOffset = 5;

    public string fileLevel = "Level_1.txt";

    // Start is called before the first frame update
    void Start()
    {
        string fullFilePath = Application.dataPath + "/" + fileLevel;

        print("Full file path: " + fullFilePath);

        print(File.ReadAllText(fullFilePath));

        string[] lines = File.ReadAllLines(fullFilePath); //lines will be an array of strings, with each line in a different slot

        GameObject wallHolder = new GameObject("Wall Holder"); //Make a GameObject to hold all the walls to make the inspector cleaner

        for (int y = 0; y < lines.Length; y++) //go through all the lines
        {
            string line = lines[y]; //get each line

            char[] characters = line.ToCharArray(); //go through each character in the line

            for (int x = 0; x < characters.Length; x++)
            {
                GameObject newObject;

                switch (characters[x]) //use switch and case to change characters to sprites
                {
                    case 'x':
                        newObject = Instantiate<GameObject>(wall);
                        newObject.transform.SetParent(wallHolder.transform); //make the parent of the new wall, Wall Holder
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;
                    case '%':
                        newObject = Instantiate<GameObject>(wall1);
                        newObject.transform.SetParent(wallHolder.transform); //make the parent of wall1, Wall Holder
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;
                    case 'P':
                        newObject = Instantiate<GameObject>(player); //instantiate player
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;
                    case '*':
                        newObject = Instantiate<GameObject>(prize); //instantiate prize
                        newObject.transform.position =
                                     new Vector2(x + xOffset, -y + yOffset);
                        break;
                    default:
                        print("empty"); //if nothing, print empty
                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
