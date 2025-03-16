using System;
using System.Collections;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cube : MonoBehaviour
{
    private Animator _anim;
    private int _numberAnimation;
    private int lastClick = 1;
    [SerializeField] private InputAction inpo;
    private bool _animIsPlay;
    private void Start()
    {
        inpo.Enable();
        _anim = GetComponent<Animator>();
    }

    private void OnDisable()
    {
        inpo.Disable();
    }
    
    private void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x+ inpo.ReadValue<float>()*0.001f, transform.localScale.y + inpo.ReadValue<float>()*0.001f, transform.localScale.z + inpo.ReadValue<float>()*0.001f);
        
    }

    public void Click1()
    {
        StartCoroutine(MyClick1());
    }
    private IEnumerator MyClick1()
    {
        if (!_animIsPlay)
        {
            if (lastClick == 1 && _numberAnimation != 134
            ) //если последний раз кликали "вперед" то перекидываем анимацию на следующую четную, но при условии, что крайняя анимация не была последней
            {
                _numberAnimation += 2;
                _anim.Play(_numberAnimation.ToString());
            }
            else if (lastClick == -1) //если последний раз кликнули назад
            {
                if (_numberAnimation == 1)
                {
                    _numberAnimation = 2;
                }
                else
                {
                    _numberAnimation -= 1;
                }

                _anim.Play(_numberAnimation.ToString());
                lastClick = 1;
            }
            _animIsPlay = true;
        }

        yield return new WaitForSeconds(0.8f);
        _animIsPlay = false;

    }
    
    public void Click2()
    {
        if (lastClick == -1 && _numberAnimation!=1)
        {
            _numberAnimation -= 2;
            _anim.Play(_numberAnimation.ToString());

        }
        else if (lastClick == 1 && _numberAnimation!=0)
        {
            _numberAnimation += 1;
            _anim.Play(_numberAnimation.ToString());
            lastClick = -1;
        }
    }

    
    
}



