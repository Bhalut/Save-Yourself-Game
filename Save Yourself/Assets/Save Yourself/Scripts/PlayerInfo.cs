using UnityEngine;

// This class will act as a container for the information of the player
public static class PlayerInfo
{
    [SerializeField]
    private static int userHealth;

    const int DEFAULT_HEALTH_VALUE = 100;
    const int MAXIMUM_HEALTH_VALUE = 100;

    public static int UserHealth
    {
        get
        {
            return userHealth;
        }
    }

    public static void ModifyUserHealth(int effect)
    {
        userHealth += effect;
        if (userHealth > MAXIMUM_HEALTH_VALUE)
        {
            userHealth = MAXIMUM_HEALTH_VALUE;
        }
        if (userHealth < 0)
        {
            userHealth = 0;
            GameManager.Instance.GameState = GameStates.GameOver;
        }
    }

    public static void ResetHealthValue()
    {
        userHealth = DEFAULT_HEALTH_VALUE;
    }
}
