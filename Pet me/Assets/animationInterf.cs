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
    //показывать тое 50 100
    public float foodLevel = 1440f; // начальный показатель еды днлить на этоже число
    private float decreaseRate = 1f; // скорость уменьшения показателя еды (единица в минуту)
    private float lastUpdateTime; // время последнего обновления

    void Start()
    {
        lastUpdateTime = Time.realtimeSinceStartup; // запоминаем время старта
    }

    void Update()
    {
        float currentTime = Time.realtimeSinceStartup;
        float timePassed = currentTime - lastUpdateTime;

        if (timePassed >= 11440f)
        { // если прошела минута
            int hoursPassed = Mathf.FloorToInt(timePassed / 1440f); // сколько прошло минут
            lastUpdateTime += hoursPassed * 3600f; // обновляем время последнего обновления

            DecreaseFoodLevel(hoursPassed); // уменьшаем показатель еды
        }
    }

    void DecreaseFoodLevel(int hoursPassed)
    {
        foodLevel -= decreaseRate * hoursPassed; // уменьшаем показатель еды
        if (foodLevel < 0f)
        {
            foodLevel = 0f; // предотвращаем отрицательные значения
        }
    }


}
