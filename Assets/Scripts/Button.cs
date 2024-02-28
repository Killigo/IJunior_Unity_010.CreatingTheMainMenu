using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Button : MonoBehaviour
{
    [SerializeField] private List<GameObject> _buttons;
    [SerializeField] private Color _color;

    private float _duration = 1f;
    private int _loops = 2;

    public void OnButtonPlay()
    {
        foreach (var button in _buttons)
        {
            int random = Random.Range(0, 2);

            if (random > 0)
                random += 5;
            else
                random -= 5;

            button.transform.DOMove(new Vector3(random, button.transform.position.y, button.transform.position.z)
                , _duration).SetLoops(_loops, LoopType.Yoyo);
        }
    }

    public void OnButtonAbout()
    {
        foreach (var button in _buttons)
        {
            button.GetComponent<Image>().DOColor(_color, _duration).SetLoops(_loops, LoopType.Yoyo);
        }
    }

    public void OnButtonExit()
    {
        foreach (var button in _buttons)
        {
            Destroy(button);
        }
    }
}
