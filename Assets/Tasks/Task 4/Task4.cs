using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private GameObject _shelfPrefab;

    private GameObject _shelf;
    
    private void Start()
    {
        _shelf =  Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя
        Destroy(_shelf);
    }
}
