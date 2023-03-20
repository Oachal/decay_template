using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Decay : MonoBehaviour
{
    public GameObject nucleus;
    public int pNum;
    public int nNum;
    public int atomicWeight;
    public Material mat1;
    public Material mat2;

    // Update is called once per frame
    void Update()
    {
     if (TiltFive.Input.TryGetButtonDown(TiltFive.Input.WandButton.One, out bool onePressed, TiltFive.ControllerIndex.Primary))
        {
            if (onePressed)
            {
                nucleus.GetComponent<MeshRenderer>().material = mat1;

            }
        }
        if (TiltFive.Input.TryGetButtonDown(TiltFive.Input.WandButton.Two, out bool twoPressed, TiltFive.ControllerIndex.Primary))
        {
            if (twoPressed)
            {
                nucleus.GetComponent<MeshRenderer>().material = mat2;

            }
        }
    }
}
