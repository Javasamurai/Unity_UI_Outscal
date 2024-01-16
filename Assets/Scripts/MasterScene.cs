using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MasterScene : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;
    
    private void Start()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            var index = i + 1;
            _buttons[i].onClick.AddListener(() => SceneManager.LoadScene("Scene_" + index));
        }
    }
}
