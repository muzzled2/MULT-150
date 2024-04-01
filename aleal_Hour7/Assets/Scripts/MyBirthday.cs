using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
   
    int birthdayMonth = 5;
    int birthDay = 9;

    void Start()
    {
       
        for (int month = 1; month <= 12; month++)
        {

            Debug.Log("Month: " + month);

            if (month == birthdayMonth)
            {

                for (int day = 1; day <= GetDaysInMonth(birthdayMonth); day++)
                {
                    if (day == birthDay)
                    {

                        Debug.Log("It's my birthday!");
                    }
                    else
                    {
                        Debug.Log("Day: " + day);

                    }
                }



            }
            else
            {
                for (int day = 1; day <= GetDaysInMonth(month); day++)
                {
                    Debug.Log("Day: " + day);
                }
                
            }
        }
    }

    int GetDaysInMonth(int month)
    {
        switch (month)
        {
            case 2: 
                return 28; 
            case 4: 
            case 6: 
            case 9: 
            case 11: 
                return 30;
            default:
                return 31;
        }
    }
}
