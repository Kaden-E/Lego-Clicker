using UnityEngine;
using UnityEngine.UIElements;

public class LegSetBuilder : MonoBehaviour
{
    public Button Button;


    private void Update()
    {
        switch (GlobalCount.LegoCount)
        {
            case <= 100:
                Debug.Log("Allow button");
                break;
            default:
                Debug.Log("Hide Button");
                break;
        }
    }
}
