using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class animationInterf : MonoBehaviour
{
    public Image Hpbar;
    //86400
    public void an()
    {
        Hpbar.fillAmount = 0.5f;
    }

    void Start()
    {
        an();
    }
    //���������� ��� 50 100
    public float foodLevel = 1440f; // ��������� ���������� ��� ������ �� ����� �����
    private float decreaseRate = 1f; // �������� ���������� ���������� ��� (������� � ������)
    private float lastUpdateTime; // ����� ���������� ����������

    void Start()
    {
        lastUpdateTime = Time.realtimeSinceStartup; // ���������� ����� ������
    }

    void Update()
    {
        float currentTime = Time.realtimeSinceStartup;
        float timePassed = currentTime - lastUpdateTime;

        if (timePassed >= 11440f)
        { // ���� ������� ������
            int hoursPassed = Mathf.FloorToInt(timePassed / 1440f); // ������� ������ �����
            lastUpdateTime += hoursPassed * 3600f; // ��������� ����� ���������� ����������

            DecreaseFoodLevel(hoursPassed); // ��������� ���������� ���
        }
    }

    void DecreaseFoodLevel(int hoursPassed)
    {
        foodLevel -= decreaseRate * hoursPassed; // ��������� ���������� ���
        if (foodLevel < 0f)
        {
            foodLevel = 0f; // ������������� ������������� ��������
        }
    }


}
