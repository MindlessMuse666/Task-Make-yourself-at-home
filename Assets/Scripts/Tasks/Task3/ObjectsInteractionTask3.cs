using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    [SerializeField] private GameObject _mainLamp;
    
    private Lamp[] _lamps;
    private void Start()
    {
        _lamps = _mainLamp.GetComponentsInChildren<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Keypad2))
        {
            foreach (var lamp in _lamps)
            {
                lamp.Interact();
            }
        }
    }
}