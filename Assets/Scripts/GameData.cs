using UnityEngine;

public static class GameData
{
    private static float gameTime;
    private static int playerDeaths;

    private static float sideForce = 55f;

    private static float volume = 0.5f;

    public static float GameTime {
        get {
            return gameTime;
        }
        set {
            gameTime = value;
        }
    }

    public static int PlayerDeaths{
        get{
            return playerDeaths;
        }
        set{
            playerDeaths = value;
        }
    }

    public static float SideForce {
        get {
            return sideForce;
        }
        set {
            sideForce = value;
        }
    }

    public static float Volume {
        get {
            return volume;
        }
        set {
            volume = value;
        }
    }
}