using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;



public class MovementManager : MonoBehaviour
{
    public static MovementManager Instance;

    [TitleGroup("Animator")]
    [SerializeField] private RuntimeAnimatorController animatorController;
    [SerializeField] private Animator animatorMovement;
    [SerializeField] private Animator currentMovement;
    [SerializeField] private Motion currentMotion;


    [SerializeField] private Animator avatar;
    [SerializeField] private Animator refAvatar;

    [TitleGroup("Settings")]
    [SerializeField] private GameObject startMovement;

    [TitleGroup("Movemements")]
    [SerializeField] private List<Animator> movements;
    public List<Animator> Movements { get => movements; set => movements = value; }

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        if (animatorController == null)
        {
            animatorController = GetComponent<RuntimeAnimatorController>();
        }

        Initialize();

    }

    private void Update()
    {

    }

    private void OnValidate()
    {

    }

    private void Initialize()
    {
        refAvatar = Instantiate(avatar);
        animatorMovement = refAvatar;

    }

    [Button("Añadir movimientos")]
    private void AddMovementAnimator()
    {
        //animatorController
    }
    public void MovementChange(string _movementData)
    {

        foreach (Animator animator in Movements)
        {
            if (animator.name == _movementData)
            {
                currentMovement = animator;
                Debug.Log("Movimientos: " + Movements.IndexOf(animator));
                //animatorController.AddMotion(currentMotion);
                animatorMovement.SetInteger("state", Movements.IndexOf(animator));

            }
        }


        //animatorController = currentMovement;
        //animatorController.SetTrigger("ChangedMovement");

    }
}
