using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public void MoveNucleus(InputAction.CallbackContext content)
    {
        this.transform.Translate(content.ReadValue<Vector2>().x, 0, content.ReadValue<Vector2>().y);
    }
   
}
