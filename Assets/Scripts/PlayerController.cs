using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Inputs")]
    [SerializeField] private InputActionAsset actions;
    [SerializeField] private InputAction moveAction;

    void Awake()
    {
        moveAction = actions.FindAction("Move");
    }
}
