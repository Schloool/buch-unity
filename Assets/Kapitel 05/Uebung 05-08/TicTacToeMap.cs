using UnityEngine;

public class TicTacToeMap : MonoBehaviour
{
    private void Start()
    {
        char[,] map =
        {
            {'X', 'O', 'X'},
            {' ', 'X', ' '},
            {'O', ' ', 'O'}
        };
        
        Debug.Log(map[1, 1]);
    }
}
