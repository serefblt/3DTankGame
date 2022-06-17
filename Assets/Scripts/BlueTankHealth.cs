using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueTankHealth : MonoBehaviour
{
    float _blueHealth = 5;
    [SerializeField] Text _blueText , _gameoverText;
    [SerializeField] GameObject _gameoverPanel, _particalPanel;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            _blueHealth--;
            _blueText.text = _blueHealth.ToString();
            Destroy(collision.gameObject);
            if (_blueHealth <= 1)
            {
                _particalPanel.SetActive(true);
            }
            if (_blueHealth <= 0)
            {
                Destroy(gameObject);
                _gameoverPanel.SetActive(true);
                _gameoverText.text = "Red Tank Win";
                _gameoverText.color = Color.red;
                Time.timeScale = 1;
            }
        }

    }

}
