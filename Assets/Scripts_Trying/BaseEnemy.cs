using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public EnemyDataSO data;
    public SpriteRenderer spriteRenderer;

    private float CurrentSpeed;

    [SerializeField] private float directionTimer = 2;
    [SerializeField] private float currentTimer;
    [SerializeField] private Vector2 CurrentDir;

    void Start()
    {
        CurrentSpeed = data.Speed;
        spriteRenderer.sprite = data.sprite;
    }

    void Update()
    {
        MoveToDirection();
        Timer();
    }
    public void Timer()
    {
        currentTimer += Time.deltaTime;
        if (currentTimer > directionTimer)
        {
            ChangeDirection();
            currentTimer = 0;
        }
    }
    public void ChangeDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        CurrentDir = new Vector2(randomX, randomY);
    }
    public void MoveToDirection()
    {
        Vector3 target = (Vector3)CurrentDir + transform.position;
        Vector3 dir = (target - transform.position).normalized;

        transform.position += dir * CurrentSpeed * Time.deltaTime;
    }
}
