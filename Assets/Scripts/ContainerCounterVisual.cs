using UnityEngine;

public class ContainerCounterVisual : MonoBehaviour
{
    private Animator animator;
    [SerializeField]private ContainerCounter containerCounter;

    private const string OPEN_CLOSE = "OpenClose";
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        containerCounter.onPlayerGrabbedObject += ContainerCounter_onPlayerGrabbedObject;
    }

    private void ContainerCounter_onPlayerGrabbedObject(object sender, System.EventArgs e)
    {
        animator.SetTrigger(OPEN_CLOSE);
    }
}
