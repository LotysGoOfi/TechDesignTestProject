using UnityEngine;

public class GemTwoController : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Click = Animator.StringToHash("Click");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger(Click);
    }
}