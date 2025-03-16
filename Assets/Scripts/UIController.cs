using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;

public class UIController : MonoBehaviour
{
    [SerializeField] private Sprite[] NextDetal;
    [SerializeField] private TMP_Text count;
    private int numberStep;
    [SerializeField] private Image _currentSprite;
    [SerializeField] private GameObject programm;
    private AudioSource _audio;
    private bool _animIsPlay;


    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }


    public void NextStep()
    {
        StartCoroutine(Next());
    }

    private IEnumerator Next()
    {
        if (!_animIsPlay)
        {
            _audio.Play();
            _animIsPlay = true;
            if (numberStep < NextDetal.Length) _currentSprite.sprite = NextDetal[numberStep];

            if (numberStep == NextDetal.Length)
            {
                programm.SetActive(true);
            }
            else
            {
                numberStep++;
                count.text = numberStep.ToString();
            }
        }
        _animIsPlay = true;
        yield return new WaitForSeconds(0.8f);
        _animIsPlay = false;
    }


    public async void PreviousStep()
    {
        if (numberStep > 0)
        {
            numberStep--;
            count.text = numberStep.ToString();
            _currentSprite.sprite = NextDetal[numberStep];
            if (numberStep < NextDetal.Length)
            {
                programm.SetActive(false);
            }
        }
    }

}
