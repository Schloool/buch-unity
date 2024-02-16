using UnityEngine;

public class CubeFlyAnimatorNoParamRead : MonoBehaviour
{
    private Animator animator;
    private bool isFlying;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFlying = !isFlying;
            animator.SetBool("isFlying", isFlying);
        }
    }
}
