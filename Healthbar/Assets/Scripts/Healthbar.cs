using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Image _healtBar;
    [SerializeField] private float _currentHealt;
    [SerializeField] private float _maxHealt;
    private Player _player;
    void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
        _healtBar = GetComponent<Image>();
    }

    void Update()
    {
        _currentHealt = _player._playerHealt;
        Debug.Log(_currentHealt);
        _healtBar.fillAmount = _currentHealt / _maxHealt;
        
    }
}
