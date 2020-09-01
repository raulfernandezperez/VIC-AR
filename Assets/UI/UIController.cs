using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;
using JetBrains.Annotations;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    [TitleGroup("Settings")]
    [SerializeField] private Vector3 distanceButtons = new Vector3(260, 0, 0);

    [TitleGroup("UI")]

    [SerializeField] private Canvas canvasMenu;
    [SerializeField] private Button movementButton;
    public Button MovementButton { get => movementButton; set => movementButton = value; }

    [SerializeField] private Text movementText;
    public Text MovementText { get => movementText; set => movementText = value; }

    private bool firstMovementButton;
    private MovementManager movementManager;
    private void Start()
    {
        movementManager = MovementManager.Instance;

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        LoadMovementButton();
    }

    private void LoadMovementButton()
    {
        foreach (Animator animator in movementManager.Movements)
        {
            if (!firstMovementButton)
            {
                MovementText.text = animator.name;
                firstMovementButton = true;
            }
            else
            {
                Instantiate(MovementButton, MovementButton.transform.position + distanceButtons, MovementButton.transform.rotation, canvasMenu.transform);
                MovementText.text = animator.name;
                distanceButtons += distanceButtons;
            }

        }

    }

}
