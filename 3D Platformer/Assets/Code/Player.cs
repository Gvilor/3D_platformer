using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //��������� ��� �������� �����
    public int coins;
    //���������� ��� ��������� ����
    public GameObject fireballPrefab;
    //����� ������ ���� 
    public Transform attackPoint;

    //������� �������� ������
    public int health = 10;
    //������������ �������� ������
    public int maxHealth = 10;

    //������������ �����
    public AudioSource audioSource;
    //���� ���������� ���� �����
    public AudioClip damageSound;

    public void CollectCoins()
    {
        coins++; //��������� 1 �������
        print("��������� �������: " +  coins);//������� �������� �������
    }

    //����� ���������� �������� ������
    public void TakeDamage(int damage)
    {
        health -= damage; // ��������� ��������

        if (health > 0)
        {
            print("�������� ������ = " + health); //������� ���-�� ������
            audioSource.PlayOneShot(damageSound);//��������������� ����� �����
        }
        else
        {

            //��������� ������� ������� ����� � �� ����������
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    void Update()
    {
        //���� ����� �������� ����� ������ ����, ��������� �������� ���
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
