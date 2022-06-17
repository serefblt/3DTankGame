using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedTankHealth : MonoBehaviour
{
    float _redHealth = 5;
    [SerializeField] Text _redText , _gameoverText;
    [SerializeField] GameObject _gameoverPanel, _particalPanel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            _redHealth--;
            _redText.text = _redHealth.ToString();
            Destroy(collision.gameObject);
            if (_redHealth <= 1)
            {
                _particalPanel.SetActive(true);
            }
            if (_redHealth <= 0)
            {
                Destroy(gameObject);
                _gameoverPanel.SetActive(true);
                _gameoverText.text = "Blue Tank Win";
                _gameoverText.color = Color.blue;
                Time.timeScale = 1;
            }
        }
      
     
    }
}
