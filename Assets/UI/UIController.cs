using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;
using JetBrains.Annotations;

public class UIController : MonoBehaviour
{
    public static UIController Instance;

    [TitleGroup("Buttons")]
    [SerializeField] private Button movementButton;
    public Button MovementButton { get => movementButton; set => movementButton = value; }

    [SerializeField] private Text movementText;
    public Text MovementText { get => movementText; set => movementText = value; }

    private void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }

    }

}
