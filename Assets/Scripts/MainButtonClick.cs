using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;

    public void ButtonClicked(){
        GlobalCount.LegoCount += 1; //Add one hat everytime you click the button.
    }
}
