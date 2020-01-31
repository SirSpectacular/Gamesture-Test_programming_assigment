using UnityEngine;
using UnityEngine.UI;

public class FadingDisplay : MonoBehaviour
{
    private float _timeLeft = 0.0f;
    private Text _text;

    public float timeOfFading = 1.0f;

    void Start()
    {
        _text = GetComponent<Text>();
        _text.color = new Color(1f, 1f, 1f, 0f);
    }

    void Update()
    {
        if(_timeLeft <= timeOfFading)
        {
            _text.color = new Color(1f, 1f, 1f, _timeLeft / timeOfFading);
        }
        if (_timeLeft > 0.0f)
        {
            _timeLeft -= Time.deltaTime;
        }
    }

    public void Display(float seconds)  
    {
        _text.color = new Color(1f, 1f, 1f, 1f);
        _timeLeft = seconds; 
    }
}
