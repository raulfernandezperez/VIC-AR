using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Sirenix.OdinInspector;


public class MovementManager : MonoBehaviour
{
    // Start is called before the first frame update
    [TitleGroup("Animator")]
    [SerializeField] private Animator animatorController;
    [SerializeField] [ReadOnly] private bool changedMovement;

    [TitleGroup("Settings")]
    [SerializeField] private Animator currentMovement;
    [SerializeField] private Animator startMovement;
    [TitleGroup("Movemements")]
    [SerializeField] [ReadOnly] private List<Animator> movements;

    private void Start()
    {

        if (animatorController == null)
        {
            animatorController = GetComponent<Animator>();
        }
        changedMovement = false;

        movements.Add(currentMovement);
        movements.Add(startMovement);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            ChangeMovement();
        }
    }


    public void ChangeMovement()
    {
        if (!changedMovement)
        {
            animatorController = currentMovement;
            changedMovement = true;
            animatorController.SetTrigger("ChangedMovement");
        }
        else
        {
            animatorController = startMovement;
            changedMovement = false;
            animatorController.SetTrigger("ChangedMovement");
            
        }
        UIController.Instance.MovementText.text = animatorController.name;
    }
}
