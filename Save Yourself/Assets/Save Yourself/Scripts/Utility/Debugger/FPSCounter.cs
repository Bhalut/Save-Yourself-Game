using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour 
{
    [SerializeField]
    private Text _text;
    
    private readonly float UpdateFrequency = 1;
    [SerializeField]
    private Gradient _colors;
    private float timer;
    private float deltaTime;

    private Color color;
    private float fps;
    private string text;
    private float msec;

    private void Start()
    {
        _colors = new Gradient();
    }

    private void Update () 
    {
        timer += Time.deltaTime;
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        if (timer >= UpdateFrequency)
        {
            timer = 0;
            Countfps();
        }
	}

    private void Countfps()
    {
        msec = deltaTime * 1000.0f;
        fps = 1.0f / deltaTime;
        text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        color = _colors.Evaluate(fps / 60);
        _text.text = text;
        _text.color = color;
    }
}
