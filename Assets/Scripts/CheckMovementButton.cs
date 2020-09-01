using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Sirenix.OdinInspector;
using UnityEngine.UI;

public class CheckMovementButton : MonoBehaviour
{
    [SerializeField] private Text textMovement;

    void Start()
    {
        
    }

    public void CheckMovementName()
    {

        MovementManager.Instance.MovementChange(textMovement.text);
    }
}
