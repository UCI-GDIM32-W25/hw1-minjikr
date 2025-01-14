using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        float moveWS = 0f;
        float moveAD = 0f;

        if (Input.GetKey(KeyCode.W)) moveWS = 1f;
        if (Input.GetKey(KeyCode.A)) moveAD = -1f;
        if (Input.GetKey(KeyCode.S)) moveWS = -1f;
        if (Input.GetKey(KeyCode.D)) moveAD = 1f;

        Vector2 movement = new Vector2(moveAD, moveWS).normalized;
        movement *= _speed * Time.deltaTime;
        _playerTransform.Translate(movement.x, movement.y, 0);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft == 0) return;


        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

        _numSeedsLeft--;
        _numSeedsPlanted++;

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
