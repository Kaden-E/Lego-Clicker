using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    public Animator anim;
    private static readonly int Click = Animator.StringToHash("click");

    public void SetAnimTrigger()
    {
        anim.SetTrigger(Click);
        
        
    }

}
