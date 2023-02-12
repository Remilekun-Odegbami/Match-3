using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PopulateSprites : MonoBehaviour
{

    public List<Sprite> Sprites = new List<Sprite>(); //List of Sprites added from the Editor to be created as GameObjects at runtime
    public GameObject ParentPanel; //Parent Panel you want the new Images to be children of

    // Use this for initialization
    void Start()
    {
        foreach (Sprite currentSprite in Sprites)
        {
            GameObject NewObj = new GameObject(); //Create the GameObject
            Image NewImage = NewObj.AddComponent<Image>(); //Add the Image Component script
            NewImage.sprite = currentSprite; //Set the Sprite of the Image Component on the new GameObject
            NewObj.GetComponent<RectTransform>().SetParent(ParentPanel.transform); //Assign the newly created Image GameObject as a Child of the Parent Panel.
            NewObj.SetActive(true); //Activate the GameObject
        }
    }
}