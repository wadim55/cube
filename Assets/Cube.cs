using System;
using System.Threading.Tasks;
using UnityEngine;

public class Cube : MonoBehaviour
{
  private int _numberAnimation = 2;
  private Animator _anim;
 
  private void Start()
  {
    _anim = GetComponent<Animator>();
  }

  async public void PlayAnimation(float reverce)
  {
    _anim.Play(_numberAnimation.ToString());
    _anim.SetFloat("reverce", reverce);
    _numberAnimation = _numberAnimation + (int)reverce;
  }
  

  
}
