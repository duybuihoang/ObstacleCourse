using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }



    [SerializeField] protected Vector3 axis;
    public Vector3 Axis { get => axis; }


    private void Awake()
    {
        if (InputManager.instance != null)
        {
            Debug.LogError("only 1 inputManager allow to exist!!!");
        }
        InputManager.instance = this;
    }

    private void FixedUpdate()
    {
        this.getMovingAxis();
    }

    private void getMovingAxis()
    {
        this.axis = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

}
