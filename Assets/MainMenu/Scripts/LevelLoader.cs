using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [Header("GAME BUTTON")]
    [SerializeField] private Button m_AA;
    [SerializeField] private Button m_TilesMatch;
    [SerializeField] private Button m_MergeBall;
    [SerializeField] private Button m_TilesBreak;

    private void Start()
    {
        m_AA.onClick.AddListener(() => { SceneManager.LoadScene(1); });
        m_TilesMatch.onClick.AddListener(() => { SceneManager.LoadScene(2); });
        m_MergeBall.onClick.AddListener(() => { SceneManager.LoadScene(3); });
        m_TilesBreak.onClick.AddListener(() => { SceneManager.LoadScene(4); });
    }
}
