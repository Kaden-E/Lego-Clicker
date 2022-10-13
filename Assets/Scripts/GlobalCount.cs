using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCount : MonoBehaviour
{
    public static int LegoCount;
    public GameObject LegoDisplay;
    public int InternalLegoCount;

    private void Update(){
        InternalLegoCount = LegoCount;
        LegoDisplay.GetComponent<Text>().text = "Studs: " + InternalLegoCount; //Store internal value when scene changes.
    }
}
