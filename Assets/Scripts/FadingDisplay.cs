using UnityEngine;
using TMPro;

public class FadingDisplay : MonoBehaviour
{
    private float _timeToDisplay= 0.0f;
    private TextMeshProUGUI _textMesh;

    public float timeOfFading = 1.0f;

    void Start()
    {
        _textMesh = GetComponent<TextMeshProUGUI>();
        _textMesh.color = new Color(1f, 1f, 1f, 0f);
    }

    void Update()
    {
        if(_timeToDisplay <= timeOfFading)
        {
            _textMesh.color = new Color(1f, 1f, 1f, _timeToDisplay / timeOfFading);
        }
        _timeToDisplay -= Time.deltaTime;
    }

    public void Display(float seconds)
    {
        _textMesh.color = new Color(1f, 1f, 1f, 1f);
        _timeToDisplay = seconds;
    }
}
