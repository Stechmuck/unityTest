using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
	private bool dragging;

    public void OnMouseDown()
    {
        Debug.Log("Down in DragAndDrop");
        dragging = true;
    }

    public void OnMouseUp()
    {
        dragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging) {
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
			transform.Translate(mousePosition);
		}
    }
}
