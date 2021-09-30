using UnityEngine;


[CreateAssetMenu]
public class Configuration : ScriptableObject
{
    [Header("Player")]
    public GameObject PlayerPrefab;
    public float PlayerSpeed;
    public float PlayerRotationSpeed;

    [Header("Weapon")]
    public GameObject BulletPrefab;
    public GameObject LaserPrefab;
    public int LaserMagazine;
    public float LaserCooldown;
    public float LaserLifetime;
    public float BulletSpeed;

    [Header("Enemies")]
    public GameObject[] BigAsteroidPrefabs;
    public GameObject[] SmallAsteroidPrefabs;
    public GameObject UFOPrefab;
    public float BigAsteroidSpeed;
    public float SmallAsteroidSpeed;
    public float UFOSpeed;

    [Header("Game field")]
    public float MinX;
    public float MaxX;
    public float MinY;
    public float MaxY;

    [Header("Input config")]
    public KeyCode BulletFire;
    public KeyCode LaserFire;
}