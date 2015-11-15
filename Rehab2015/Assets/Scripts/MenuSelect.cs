using UnityEngine;
using System.Collections;

public class MenuSelect : MonoBehaviour {
    RaycastHit hit;
    TextMesh text;
    Color defaultColor;
    public string ClickEvent;
    bool hovered = false;
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Application.LoadLevel("SixenseHands");
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "MenuButton" && hit.collider.isTrigger)
            {
                text = hit.collider.GetComponent<TextMesh>();
                if (!hovered) defaultColor = text.color;
                text.color = new Color(1, 0, 0);
                hovered = true;
            }
            else if(hit.collider.tag == "PlayGameButton")
            {
                text = hit.collider.GetComponent<TextMesh>();
                if (!hovered) defaultColor = text.color;
                text.color = new Color(1, 0, 0);
                hovered = true;

            }

            else
            {
                if (text != null)
                {
                    if (hovered)
                    {
                        text.color = defaultColor;
                    }
                }
            }
        }
        else
        {

            if(text != null)
            {
                if(hovered)
                {
                    text.color = defaultColor;
                }
            }

        }
    }
}
