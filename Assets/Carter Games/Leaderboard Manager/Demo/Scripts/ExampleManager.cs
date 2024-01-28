using UnityEngine;
using UnityEngine.UI;

namespace CarterGames.Assets.LeaderboardManager.Demo
{
    public class ExampleManager : MonoBehaviour
    {
        [SerializeField] private InputField playerName;
        
        
        public void AddToBoard()
        {
            if (playerName.text.Length <= 0 )
            {
                Debug.Log($"<color=D6BA64><b>Leaderboard Manager Example</b> | Either the name or score fields were blank, please ensure the fields are filled before using this option.</color>");
                return;
            }
            
            LeaderboardManager.AddEntryToBoard("tirakaka", playerName.text, MonoComportamiento.score);
            playerName.text = string.Empty;
        }
    }
}