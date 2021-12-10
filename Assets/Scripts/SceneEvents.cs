using UnityEngine;
using UnityEngine.Events;
using System.Collections;
public class SceneEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _startLevel;
    [SerializeField] private UnityEvent _startScene;
    [SerializeField] private UnityEvent _gameOver;
    [SerializeField] private float _startLevelDelay;
    private static SceneEvents sceneEvents;
    private void Start()
    {
        sceneEvents = this;
    }
    public static SceneEvents Instance()
    {
        return sceneEvents;
    }
    public void StartLevel()
    {
        StartCoroutine(WaitStart(_startLevelDelay));
    }
    private IEnumerator WaitStart(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        _startLevel.Invoke();
        StopCoroutine(WaitStart(seconds));
    }
    public void StartScene()
    {
        _startScene.Invoke();
    }
    private void Awake()
    {
        StartScene();
    }
    public void GameOver()
    {
        _gameOver.Invoke();
    }
}
