using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMovekeyDisplay : MonoBehaviour
{
    public Image[] buttons = new Image[4];
    public Sprite[] unpress = new Sprite[4];
    public Sprite[] press = new Sprite[4];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            buttons[0].sprite = press[0];
        }
        else if (Input.GetKeyUp((KeyCode.W)))
        {
            buttons[0].sprite = unpress[0];
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            buttons[1].sprite = press[1];
        }
        else if (Input.GetKeyUp((KeyCode.S)))
        {
            buttons[1].sprite = unpress[1];
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            buttons[2].sprite = press[2];
        }
        else if (Input.GetKeyUp((KeyCode.A)))
        {
            buttons[2].sprite = unpress[2];
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            buttons[3].sprite = press[3];
        }
        else if (Input.GetKeyUp((KeyCode.D)))
        {
            buttons[3].sprite = unpress[3];
        }
    }
}
