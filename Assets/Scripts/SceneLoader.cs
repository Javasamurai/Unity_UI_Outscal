using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Button backButton;
    
    const string MASTER_SCENE = "Master_Scene";
    void Start()
    {
        backButton.onClick.AddListener(MasterScene);
    }

    private void MasterScene()
    {
        SceneManager.LoadScene(MASTER_SCENE);
    }
}
