using System.Collections;
using TMPro;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Animator _anim;
    private int _numberAnimation;
    private int lastClick = 1;
   

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void Click1()
    {
        if (lastClick == 1)
        {
            _numberAnimation += 2;
            _anim.Play(_numberAnimation.ToString());
            print(_numberAnimation);

        }
        else if (lastClick == -1)
        {
            _numberAnimation -= 1;
            _anim.Play(_numberAnimation.ToString());
            lastClick = 1;
            print(_numberAnimation);
        }
    }
    
    public void Click2()
    {
        if (lastClick == -1)
        {
            _numberAnimation -= 2;
            _anim.Play(_numberAnimation.ToString());
            print(_numberAnimation);

        }
        else if (lastClick == 1)
        {
            _numberAnimation += 1;
            _anim.Play(_numberAnimation.ToString());
            lastClick = -1;
            print(_numberAnimation);
        }
    }

    
    
}



