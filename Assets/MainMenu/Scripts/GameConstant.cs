using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConstant : MonoBehaviour
{
    public static GameConstant Instance { get; private set; }

    private const string PlayerNameKey = "PLAYER_NAME";
    private const string playerAvatarIndexKey = "PLAYER_AVATAR_INDEX";

    public string PlayerName
    {
        get { return PlayerPrefs.GetString(PlayerNameKey, "You"); }

        set { PlayerPrefs.SetString(PlayerNameKey,value); }
    }

    public int PlayerAvatarIndex
    {
        get { return PlayerPrefs.GetInt(playerAvatarIndexKey, 0); }

        set { PlayerPrefs.SetInt(playerAvatarIndexKey, value); }
    }

    private void Awake()
    {
        if (Instance != null)
            Destroy(this.gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Start()
    {
        
    }
}
