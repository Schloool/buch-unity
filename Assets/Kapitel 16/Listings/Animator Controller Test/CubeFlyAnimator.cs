using UnityEngine;

public class CubeFlyAnimator : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bool currentValue = animator.GetBool("isFlying");
            animator.SetBool("isFlying", !currentValue);
        }
    }
}
