using UnityEngine;
using UnityEngine.EventSystems;

public class BlockCamera : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject CameraMover;

    public void OnPointerEnter(PointerEventData eventData)
    {
       CameraMover.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        CameraMover.SetActive(true);
    }
}
