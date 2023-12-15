using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] private GameObject _lampPrefab;
    [SerializeField] private Transform _parent;
    private void Awake()
    {
        Instantiate(_lampPrefab, _parent);
    }    
}