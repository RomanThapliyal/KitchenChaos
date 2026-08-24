using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    [SerializeField]private Player player;
    private const string IS_WALKING = "IsWalking";
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool(IS_WALKING, false);
    }
    private void Update()
    {
        animator.SetBool (IS_WALKING, player.IsWalking());
    }
}
