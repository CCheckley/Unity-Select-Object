using UnityEngine;

public class SelectObject : MonoBehaviour
{
    void Update()
    {
        // Call every frame
        MouseInput();
    }

    void MouseInput()
    {
        // When Mouse 0 is pressed
        if (Input.GetMouseButton(0))
        {
            // Set if the Physics.Raycast returns true
            RaycastHit hitInfo;

            // Setup ray based on mouse input position
            Ray rayFromMouseInput = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Populates hitInfo if returns true
            if (Physics.Raycast(rayFromMouseInput, out hitInfo))
            {
                // Log the name of the hit object
                Debug.Log(hitInfo.collider.gameObject.name);
                Debug.DrawRay(
                    rayFromMouseInput.origin,
                    rayFromMouseInput.direction * 1000.0f,
                    Color.yellow
                ); // Default ray length to 1000 for debug
            }
        }
    }
}
