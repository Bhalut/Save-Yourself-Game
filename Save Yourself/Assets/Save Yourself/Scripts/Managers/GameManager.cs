/// <Summary>
/// Manager in charge only of the states of the game using enumerations
/// This class has a property that allows other classes to acces the game state 
/// also has a call to the event StateModified whenever the state is changed.
/// </Summary>
public class GameManager : Singleton<GameManager>
{
    private GameStates gameState;

    /*
    the variable "gameState" is private to avoid being damaged by another class, but it can be modified with 
    the public variable "GameStates". I think this is related to the principle (open-closed) of the system 
    s.o.l.i.d. (open to extensions, closed to modifications) the "GameState" is a property (getter and the setter), 
    which gives access to the variables to modify them.
    */

    public delegate void ModifiedState(GameStates newGameState);
    public event ModifiedState OnModifiedState;
    // this is the event that should be called when any class changes the game state. If another class wishes 
    // to register for this event, you must call "OnModifiedState" not the "ModifiedState"

    public GameStates GameState
    {
        get
        {
            return gameState;
        }

        set
        {
            if (gameState != value)
            {
                bool changeAccepted = false;
                switch (gameState)
                {
                    case GameStates.MainMenu:
                        changeAccepted |= value == GameStates.ChoosingCharacter;
                        break;

                    case GameStates.ChoosingCharacter:
                        changeAccepted |= value == GameStates.Play;
                        break;

                    case GameStates.Play:
                        changeAccepted |= (value == GameStates.GameOver || value == GameStates.Pause);
                        break;

                    case GameStates.Pause:
                        changeAccepted |= (value == GameStates.MainMenu || value == GameStates.Play);
                        break;
                    case GameStates.GameOver:
                        changeAccepted |= (value == GameStates.MainMenu || value == GameStates.Play);
                        break;
                }

                // you can not go from one game state to whatever other state, you must follow a certain rules, and for this are all the conditionals
                // if these arent true, then it should not change the state

                if (changeAccepted)
                {
                    gameState = value;

                    if (OnModifiedState != null)
                        OnModifiedState(gameState);
                }
            }
        }
    }
}

// enumeration with the possibles states of the game
public enum GameStates
{
    MainMenu,
    ChoosingCharacter,
    Play,
    GameOver,
    Pause
}