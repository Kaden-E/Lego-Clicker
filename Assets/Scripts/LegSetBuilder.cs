using UnityEngine;
using UnityEngine.UI;

public class LegSetBuilder : MonoBehaviour
{
    private Button _button;
    private Image _image;
    private Text _txt;

    private void Start()
    {
        _button = GetComponent<Button>();
        _image = GetComponent<Image>();
        _txt = GetComponentInChildren<Text>();
    }

    private void Update()
    {
        switch (GlobalCount.LegoCount)
        {
            case >= 6:
                _button.enabled = true;
                _image.enabled = true;
                _txt.enabled = true;
                //Debug.Log("Allow button");
                break;
            default:
                _button.enabled = false;
                _image.enabled = false;
                _txt.enabled = false;
                //Debug.Log("Hide Button");
                break;
        }
    }
}
