using System.Collections;
using UnityEngine;

public class LightController : MonoBehaviour
{

    public static LightController instance { get; private set; }
    private float _maxFogVal = 1f;
    Color _initialColor = Color.white;
    float _transitionDuration = 5f;
    private IEnumerator _currentChangeCR;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        RenderSettings.fogColor = _initialColor;
        SwitchColor(Color.black);
    }

    void Update()
    {
    }

    public void SwitchColor(Color32 target)
    {
        if (_currentChangeCR != null)
        {
            StopCoroutine(_currentChangeCR);
        }
        _currentChangeCR = SwitchColorCR(target);
        StartCoroutine(_currentChangeCR);
    }

    IEnumerator SwitchColorCR(Color32 target)
    {
        float currentTime = 0f; ;
        float deltaTime = 0.1f;
        Color originalColor = RenderSettings.fogColor;
        while (currentTime < _transitionDuration)
        {
            currentTime += deltaTime;
            Color newColor = Color.Lerp(originalColor, target, currentTime / _transitionDuration);
            RenderSettings.fogColor = new Color(ClampColorValue(newColor.r), ClampColorValue(newColor.g), ClampColorValue(newColor.b), 1);
            yield return new WaitForSeconds(deltaTime);
        }

    }

    private float ClampColorValue(float val)
    {
        return Mathf.Clamp(val, 0, _maxFogVal);
    }
}
