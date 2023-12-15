using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private GameObject _wafflePrefab;
    [SerializeField] private GameObject _waffleRoot;
    [SerializeField] private Toaster _toaster;

    private void Awake()
    {
        _toaster = FindObjectOfType<Toaster>();
        _toaster.TimerIsUp += SpawnWaffle;
    }

    private void SpawnWaffle()
    {
        Instantiate(_wafflePrefab, _waffleRoot.transform);
        _toaster.TimerIsUp -= SpawnWaffle;
    }
}